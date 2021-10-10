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
        private IntervalTrainer _trainer;
        private int _score;
        public MainForm()
        {
            InitializeComponent();

            _trainer = new IntervalTrainer();

            KeyUp += OnKeyUp;
        }

        private void OnKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _trainer.PlayRandomRisingInterval();
            }

            if (Keys.D2 <= e.KeyCode && e.KeyCode <= Keys.D9)
            {
                int interval = e.KeyCode - Keys.D2;

                if (_trainer.CorrectInterval == interval)
                {
                    _score++;
                    label_score.Text = _score.ToString();
                }

                label_from.Text = "C";
                label_to.Text = "D";
                label_interval.Text = "major second";
            }
        }
    }
}
