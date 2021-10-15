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

            var items = checkedListBox_intervals.Items;
            foreach (var interval in Enum.GetValues<Interval>())
            {
                items.Add(interval.ToText());
            }

            checkedListBox_intervals.ItemCheck += CheckedListBox_intervalsOnItemCheck;
            checkedListBox_intervals.KeyUp += CheckedListBox_intervalsOnKeyUp;

            _trainer = new PitchTrainer(new TimedMidiPlayer());
        }

        private void CheckedListBox_intervalsOnKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                _trainer.Poke();

                label_from.Text = "--";
                label_to.Text = "--";
                label_interval.Text = "--";
            }
        }

        private void CheckedListBox_intervalsOnItemCheck(object? sender, ItemCheckEventArgs e)
        {
            Interval interval = (Interval)e.Index;
            e.NewValue = CheckState.Unchecked;

            if (_trainer.VerifyInterval(interval))
            {
                _score++;
                label_score.Text = _score.ToString();

                label_from.Text = _trainer.StartTone.LetterWithOctave;
                label_to.Text = _trainer.EndTone.LetterWithOctave;
                label_interval.Text = _trainer.CorrectInterval.ToText();
            }
        }
    }
}
