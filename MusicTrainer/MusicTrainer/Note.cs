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

        B ,
    }

    public static class NoteExtentions
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

        private static readonly Dictionary<Note, int> Midi =
            new Dictionary<Note, int>
            {
                {Note.C , 60},
                {Note.Cs, 61},
                {Note.Db, 61},
                {Note.D , 62},
                {Note.Ds, 63},
                {Note.Eb, 63},
                {Note.E , 64},
                {Note.F , 65},
                {Note.Fs, 66},
                {Note.Gb, 66},
                {Note.G , 67},
                {Note.Gs, 68},
                {Note.Ab, 68},
                {Note.A , 69},
                {Note.As, 70},
                {Note.Bb, 70},
                {Note.B , 71},
            };

        public static string ToLetter(this Note note) => Letters[note];
        public static int ToMidi(this Note note) => Midi[note];
    }
}
