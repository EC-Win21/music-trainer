using MusicTrainer;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class TheoryTests
    {
        [Fact]
        public void TestTone()
        {
            var tone = new Tone(Note.Cs);

            Assert.Equal("C♯", tone.Letter);
            Assert.Equal("C♯4", tone.LetterWithOctave);
            Assert.Equal(4, tone.Octave);
            Assert.Equal(61, tone.Midi);
        }


        [Fact]
        public void TestToneEquality()
        {
            var cSharp = new Tone(Note.Cs);
            var dFlat = new Tone(Note.Db);

            Assert.Equal(cSharp.Midi, dFlat.Midi);
        }

        [Fact]
        public void TestToneOneOctaveUp()
        {
            var tone = new Tone(Note.Cs, 5);

            Assert.Equal("C♯", tone.Letter);
            Assert.Equal("C♯5", tone.LetterWithOctave);
            Assert.Equal(5, tone.Octave);
            Assert.Equal(60 + 12 + 1, tone.Midi);
        }

        [Fact]
        public void TestToneIntervalAddition()
        {
            var interval = Interval.MajorThird;
            Assert.Equal(4, (int)interval);

            var tone = new Tone(Note.C, 5);
            var newTone = tone + interval;

            Assert.Equal("E", newTone.Letter);
            Assert.Equal("E5", newTone.LetterWithOctave);
            Assert.Equal(5, newTone.Octave);
            Assert.Equal(60 + 12 + 4, newTone.Midi);
        }

        [Fact]
        public void TestToneIntervalSubtraction()
        {
            var interval = Interval.Tritone;
            Assert.Equal(6, (int)interval);

            var tone = new Tone(Note.C, 4);
            var lower = tone - interval;

            Assert.Equal("F♯", lower.Letter);
            Assert.Equal("F♯3", lower.LetterWithOctave);
            Assert.Equal(3, lower.Octave);
            Assert.Equal(60 - 6, lower.Midi);
        }
    }
}
