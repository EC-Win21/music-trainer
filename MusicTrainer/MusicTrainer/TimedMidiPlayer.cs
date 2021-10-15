using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NAudio.Midi;

namespace MusicTrainer
{
    public class TimedMidiPlayer : IToneQueuer
    {

        private readonly Timer _timer;
        private readonly Stopwatch _stopwatch;
        private readonly MidiOut _midiOut;
        private readonly Queue<QueuedTone> _queue;
        public TimedMidiPlayer()
        {
            /*for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                MidiOut.DeviceInfo(device);
            }*/
            _midiOut = new MidiOut(1);

            _timer = new Timer();
            _timer.Elapsed += OnTimedEvent;

            _stopwatch = new Stopwatch();

            _queue = new Queue<QueuedTone>();
        }

        public void ClearQueue() => Reset();
        public void QueueToneIn(Tone tone, int milliseconds, int velocity = 100, int duration = 20)
        {
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
                _timer.Interval = Math.Max(1, milliseconds);
                _timer.Start();
            }

            _queue.Enqueue(new QueuedTone()
            {
                Tone = tone,
                Target = milliseconds,
                Velocity = velocity,
                Duration = duration,
            });
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            var queuedTone = _queue.Dequeue();

            var noteOn = new NoteOnEvent(0, 1, queuedTone.Tone.Midi, queuedTone.Velocity, queuedTone.Duration);
            _midiOut.Send(noteOn.GetAsShortMessage());

            if (_queue.Count > 0)
            {
                var nextQueuedTone = _queue.Peek();
                _timer.Interval = nextQueuedTone.Target - (int)_stopwatch.ElapsedMilliseconds;
            }
            else
            {
                Reset();
            }
        }

        private void Reset()
        {
            _queue.Clear();
            _timer.Stop();
            _stopwatch.Reset();
        }

        record QueuedTone
        {
            public Tone Tone { get; init; }
            public int Target { get; init; }
            public int Velocity { get; init; }
            public int Duration { get; init; }
        }
    }
}
