using System;
using System.Threading;
using NAudio.Midi;

namespace MusicTrainer
{
    public class IntervalTrainer
    {
        private readonly MidiOut _midiOut;

        public IntervalTrainer()
        {
            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                MidiOut.DeviceInfo(device);
            }

            _midiOut = new MidiOut(1);
        }

        public int CorrectInterval { get; private set; }

        public void PlayRandomRisingInterval()
        {
            var a = new NoteOnEvent(0, 1, 60, 100, 20);
            var b = new NoteOnEvent(0, 1, 62, 100, 20);
            
            _midiOut.Send(a.GetAsShortMessage());
            Thread.Sleep(1000);
            _midiOut.Send(b.GetAsShortMessage());

            CorrectInterval = 2;
        }
    }
}
