using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTrainer
{
    public enum Interval
    {
        Tonic = 0,
        MinorSecond,
        MajorSecond,
        MinorThird,
        MajorThird,
        PerfectFourth,
        Tritone,
        PerfectFifth,
        MinorSixth,
        MajorSixth,
        MinorSeventh,
        MajorSeventh,
        Octave,
    }

    public static class IntervalHelper{
        public static string ToText(this Interval interval)
        {
            return Enum.GetName(interval);
        }
    }
}
