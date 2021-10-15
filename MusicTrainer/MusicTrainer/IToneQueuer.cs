using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTrainer
{
    public interface IToneQueuer
    {
        public void ClearQueue();
        public void QueueToneIn(Tone tone, int milliseconds, int velocity = 100, int duration = 20);
    }
}
