using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTrainer
{
    public record Tone
    {
        private readonly Note _note;
        public int Octave { get; init; }
        public int Midi => _note.ToMidi() + (Octave - 4) * 12;
        public string Letter => _note.ToLetter();
        public string LetterWithOctave => _note.ToLetter() + Octave;
        public Tone(Note note, int octave = 4)
        {
            _note = note;
            Octave = octave;
        }

        public static Tone operator -(Tone tone, Interval interval)
        {
            var midi = tone.Midi - (int) interval;

            var octave = (midi / 12) - 2;
            var note = (Note) (3);

            return new Tone(note, octave);
        }
        public static Tone operator +(Tone tone, Interval interval)
        {
            var midi = tone.Midi - (int)interval;

            var octave = (midi / 12) - 2;
            var note = (Note)(3);

            return new Tone(note, octave);
        }
    }
}
