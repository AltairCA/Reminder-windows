namespace Reminder
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.StartTimerBtn = new System.Windows.Forms.Button();
            this.minutesText = new System.Windows.Forms.TextBox();
            this.secondsText = new System.Windows.Forms.TextBox();
            this.StopTimerBtn = new System.Windows.Forms.Button();
            this.StopAlarmBtn = new System.Windows.Forms.Button();
            this.VolumeController = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeController)).BeginInit();
            this.SuspendLayout();
            // 
            // StartTimerBtn
            // 
            this.StartTimerBtn.Location = new System.Drawing.Point(11, 54);
            this.StartTimerBtn.Name = "StartTimerBtn";
            this.StartTimerBtn.Size = new System.Drawing.Size(75, 23);
            this.StartTimerBtn.TabIndex = 0;
            this.StartTimerBtn.Text = "Start Timer";
            this.StartTimerBtn.UseVisualStyleBackColor = true;
            this.StartTimerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // minutesText
            // 
            this.minutesText.Location = new System.Drawing.Point(12, 24);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(74, 20);
            this.minutesText.TabIndex = 1;
            this.minutesText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secondsText
            // 
            this.secondsText.Location = new System.Drawing.Point(93, 24);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(74, 20);
            this.secondsText.TabIndex = 2;
            this.secondsText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StopTimerBtn
            // 
            this.StopTimerBtn.Location = new System.Drawing.Point(172, 54);
            this.StopTimerBtn.Name = "StopTimerBtn";
            this.StopTimerBtn.Size = new System.Drawing.Size(104, 23);
            this.StopTimerBtn.TabIndex = 3;
            this.StopTimerBtn.Text = "Stop Timer";
            this.StopTimerBtn.UseVisualStyleBackColor = true;
            this.StopTimerBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // StopAlarmBtn
            // 
            this.StopAlarmBtn.Location = new System.Drawing.Point(92, 54);
            this.StopAlarmBtn.Name = "StopAlarmBtn";
            this.StopAlarmBtn.Size = new System.Drawing.Size(75, 23);
            this.StopAlarmBtn.TabIndex = 4;
            this.StopAlarmBtn.Text = "Stop Alarm";
            this.StopAlarmBtn.UseVisualStyleBackColor = true;
            this.StopAlarmBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // VolumeController
            // 
            this.VolumeController.AutoSize = false;
            this.VolumeController.Location = new System.Drawing.Point(173, 19);
            this.VolumeController.Name = "VolumeController";
            this.VolumeController.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VolumeController.Size = new System.Drawing.Size(104, 25);
            this.VolumeController.TabIndex = 5;
            this.VolumeController.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeController.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seconds";
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.Text = "notifyIcon1";
            this.mynotifyicon.Visible = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 87);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolumeController);
            this.Controls.Add(this.StopAlarmBtn);
            this.Controls.Add(this.StopTimerBtn);
            this.Controls.Add(this.secondsText);
            this.Controls.Add(this.minutesText);
            this.Controls.Add(this.StartTimerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Opacity = 0.9D;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTimerBtn;
        private System.Windows.Forms.TextBox minutesText;
        private System.Windows.Forms.TextBox secondsText;
        private System.Windows.Forms.Button StopTimerBtn;
        private System.Windows.Forms.Button StopAlarmBtn;
        private System.Windows.Forms.TrackBar VolumeController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon mynotifyicon;
    }
}

