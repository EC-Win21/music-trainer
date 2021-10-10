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
        public void TestToneOneOctaveUp()
        {
            var tone = new Tone(Note.Cs, 5);

            Assert.Equal("C♯", tone.Letter);
            Assert.Equal("C♯5", tone.LetterWithOctave);
            Assert.Equal(5, tone.Octave);
            Assert.Equal(61 + 12, tone.Midi);
        }

        [Fact]
        public void TestIntervalArithmetic()
        {
            var interval = Interval.Tritone;
            var tone = new Tone(Note.D, 5);

            var lower = tone - interval;
            var higher = tone + interval;

            Assert.Equal(6, (int)interval);

            Assert.Equal("A", lower.Letter);
            Assert.Equal("A4", lower.LetterWithOctave);
            Assert.Equal(5, lower.Octave);
            Assert.Equal(69, lower.Midi);

            Assert.Equal("A", higher.Letter);
            Assert.Equal("A4", higher.LetterWithOctave);
            Assert.Equal(5, higher.Octave);
            Assert.Equal(69, higher.Midi);
        }
    }
}
