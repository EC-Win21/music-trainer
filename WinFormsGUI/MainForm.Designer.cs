
namespace WinFormsGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_interval = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.checkedListBox_intervals = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(353, 319);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(65, 32);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "to";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.Info;
            this.label_from.Location = new System.Drawing.Point(353, 372);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(34, 32);
            this.label_from.TabIndex = 2;
            this.label_from.Text = "--";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.SystemColors.Info;
            this.label_to.Location = new System.Drawing.Point(901, 372);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(34, 32);
            this.label_to.TabIndex = 3;
            this.label_to.Text = "--";
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.BackColor = System.Drawing.SystemColors.Info;
            this.label_interval.Location = new System.Drawing.Point(523, 339);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(34, 32);
            this.label_interval.TabIndex = 4;
            this.label_interval.Text = "--";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_score.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_score.Location = new System.Drawing.Point(599, 168);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(59, 71);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "0";
            // 
            // checkedListBox_intervals
            // 
            this.checkedListBox_intervals.FormattingEnabled = true;
            this.checkedListBox_intervals.Location = new System.Drawing.Point(12, -3);
            this.checkedListBox_intervals.Name = "checkedListBox_intervals";
            this.checkedListBox_intervals.Size = new System.Drawing.Size(304, 616);
            this.checkedListBox_intervals.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 666);
            this.Controls.Add(this.checkedListBox_intervals);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.CheckedListBox checkedListBox_intervals;
    }
}

