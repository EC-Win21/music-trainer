using System;
using System.Threading;
using NAudio.Midi;

namespace MusicTrainer
{
    public class PitchTrainer
    {
        public Interval CorrectInterval { get; private set; }
        public Tone StartTone { get; private set; }
        public Tone EndTone { get; private set; }
        
        private readonly IToneQueuer _queuer;
        private readonly Random _random;
        private bool _guessing;

        public PitchTrainer(IToneQueuer queuer)
        {
            _queuer = queuer;
            _random = new Random();
        }

        public void Poke()
        {
            if (!_guessing)
            {
                GenerateRandomRisingInterval();
                _guessing = true;
            }
            QueueUpRisingInterval();
        }
        private void GenerateRandomRisingInterval()
        {
            CorrectInterval = (Interval)_random.Next((int) Interval.Tonic, (int) Interval.Octave + 1);
            StartTone = new Tone((Note)_random.Next((int)Note.C, (int)Note.B + 1), _random.Next(3, 6));
            EndTone = StartTone + CorrectInterval;
        }

        private void QueueUpRisingInterval()
        {
            _queuer.ClearQueue();
            _queuer.QueueToneIn(StartTone, 0);
            _queuer.QueueToneIn(EndTone, 1000);
        }

        public bool VerifyInterval(Interval guess)
        {
            if (guess == CorrectInterval)
            {
                _guessing = false;
                return true;
            }

            return false;
        }
    }
}
