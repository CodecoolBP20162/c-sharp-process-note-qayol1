namespace ProcessList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.ListOfTasks = new System.Windows.Forms.ListBox();
            this.TaskIdLabel = new System.Windows.Forms.Label();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.RunningTimeLabel = new System.Windows.Forms.Label();
            this.MemoryUsageLabel = new System.Windows.Forms.Label();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(455, 37);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(63, 13);
            this.TaskNameLabel.TabIndex = 1;
            this.TaskNameLabel.Text = "Task name:";
            // 
            // ListOfTasks
            // 
            this.ListOfTasks.FormattingEnabled = true;
            this.ListOfTasks.Location = new System.Drawing.Point(33, 37);
            this.ListOfTasks.Name = "ListOfTasks";
            this.ListOfTasks.Size = new System.Drawing.Size(388, 290);
            this.ListOfTasks.TabIndex = 0;
            this.ListOfTasks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TaskIdLabel
            // 
            this.TaskIdLabel.AutoSize = true;
            this.TaskIdLabel.Location = new System.Drawing.Point(455, 66);
            this.TaskIdLabel.Name = "TaskIdLabel";
            this.TaskIdLabel.Size = new System.Drawing.Size(48, 13);
            this.TaskIdLabel.TabIndex = 2;
            this.TaskIdLabel.Text = "Task ID:";
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.Location = new System.Drawing.Point(455, 191);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(64, 13);
            this.CpuUsageLabel.TabIndex = 3;
            this.CpuUsageLabel.Text = "CPU usage:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(455, 95);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.StartTimeLabel.TabIndex = 4;
            this.StartTimeLabel.Text = "Start time:";
            // 
            // RunningTimeLabel
            // 
            this.RunningTimeLabel.AutoSize = true;
            this.RunningTimeLabel.Location = new System.Drawing.Point(455, 126);
            this.RunningTimeLabel.Name = "RunningTimeLabel";
            this.RunningTimeLabel.Size = new System.Drawing.Size(72, 13);
            this.RunningTimeLabel.TabIndex = 5;
            this.RunningTimeLabel.Text = "Running time:";
            // 
            // MemoryUsageLabel
            // 
            this.MemoryUsageLabel.AutoSize = true;
            this.MemoryUsageLabel.Location = new System.Drawing.Point(455, 157);
            this.MemoryUsageLabel.Name = "MemoryUsageLabel";
            this.MemoryUsageLabel.Size = new System.Drawing.Size(79, 13);
            this.MemoryUsageLabel.TabIndex = 6;
            this.MemoryUsageLabel.Text = "Memory usage:";
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.Location = new System.Drawing.Point(455, 224);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(49, 13);
            this.ThreadsLabel.TabIndex = 7;
            this.ThreadsLabel.Text = "Threads:";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(458, 306);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(333, 20);
            this.NoteTextBox.TabIndex = 8;
            this.NoteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(458, 287);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(38, 13);
            this.Notes.TabIndex = 9;
            this.Notes.Text = "Notes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 361);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.MemoryUsageLabel);
            this.Controls.Add(this.RunningTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.CpuUsageLabel);
            this.Controls.Add(this.TaskIdLabel);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.ListOfTasks);
            this.Name = "Form1";
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.ListBox ListOfTasks;
        private System.Windows.Forms.Label TaskIdLabel;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label RunningTimeLabel;
        private System.Windows.Forms.Label MemoryUsageLabel;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label Notes;
    }
}

