using MusicTrainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGUI
{
    public partial class MainForm : Form
    {
        private PitchTrainer _trainer;
        private int _score;
        public MainForm()
        {
            InitializeComponent();

            _trainer = new PitchTrainer(new TimedMidiPlayer());

            KeyUp += OnKeyUp;
        }

        private void OnKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _trainer.Poke();
            }

            if (e.KeyCode is >= Keys.D0 and <= Keys.D9)
            {
                Interval interval = (Interval)(e.KeyCode - Keys.D0);

                if (_trainer.VerifyInterval(interval))
                {
                    _score++;
                    label_score.Text = _score.ToString();
                }

                label_from.Text = _trainer.StartTone.LetterWithOctave;
                label_to.Text = _trainer.EndTone.LetterWithOctave;
                label_interval.Text = _trainer.CorrectInterval.ToText();
            }
        }
    }
}
