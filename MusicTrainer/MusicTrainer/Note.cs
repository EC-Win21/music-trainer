using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTrainer
{
    public enum Note
    {
        C ,

        Cs,
        Db,

        D ,

        Ds,
        Eb,

        E ,

        F ,

        Fs,
        Gb,

        G ,

        Gs,
        Ab,

        A ,

        As,
        Bb,

        B,
    }

    public static class NoteHelper
    {
        private static readonly Dictionary<Note, string> Letters =
            new Dictionary<Note, string>
            {
                {Note.C , "C"},
                {Note.Cs, "C♯"},
                {Note.Db, "D♭"},
                {Note.D , "D"},
                {Note.Ds, "D♯"},
                {Note.Eb, "E♭"},
                {Note.E , "E"},
                {Note.F , "F"},
                {Note.Fs, "F♯"},
                {Note.Gb, "G♭"},
                {Note.G , "G"},
                {Note.Gs, "G♯"},
                {Note.Ab, "A♭"},
                {Note.A , "A"},
                {Note.As, "A♯"},
                {Note.Bb, "B♭"},
                {Note.B , "B"},
            };

        private static readonly Dictionary<Note, int> HalfStep =
            new Dictionary<Note, int>
            {
                {Note.C , 0},
                {Note.Cs, 1},
                {Note.Db, 1},
                {Note.D , 2},
                {Note.Ds, 3},
                {Note.Eb, 3},
                {Note.E , 4},
                {Note.F , 5},
                {Note.Fs, 6},
                {Note.Gb, 6},
                {Note.G , 7},
                {Note.Gs, 8},
                {Note.Ab, 8},
                {Note.A , 9},
                {Note.As, 10},
                {Note.Bb, 10},
                {Note.B , 11},
            };
        public static string ToLetter(this Note note) => Letters[note];
        public static int ToHalfStep(this Note note) => HalfStep[note];
        public static Note FromHalfStepWithSharpBias(int halfStep)
        {
            Debug.Assert(halfStep is >= 0 and <= 11, "halfStep out of bounds");
            return HalfStep
                .Where(kv => kv.Value == halfStep)
                .Select(kv => kv.Key)
                .First();
        }
    }
}
