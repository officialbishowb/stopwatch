namespace stopwatch
{
    partial class stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Segoe UI", 105F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timer.ForeColor = System.Drawing.Color.White;
            this.timer.Location = new System.Drawing.Point(62, 9);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(588, 186);
            this.timer.TabIndex = 0;
            this.timer.Text = "00:00:00";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(125, 236);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(146, 56);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(277, 236);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(146, 56);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(429, 236);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(146, 56);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // counter
            // 
            this.counter.Enabled = true;
            this.counter.Interval = 1000;
            this.counter.Tick += new System.EventHandler(this.counter_Tick);
            // 
            // stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(683, 358);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.timer);
            this.MaximumSize = new System.Drawing.Size(699, 397);
            this.MinimumSize = new System.Drawing.Size(699, 397);
            this.Name = "stopwatch";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timer;
        private Button resetBtn;
        private Button startBtn;
        private Button stopBtn;
        private System.Windows.Forms.Timer counter;
    }
}