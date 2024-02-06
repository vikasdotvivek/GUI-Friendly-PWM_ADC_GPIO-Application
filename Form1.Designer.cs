namespace GUI_Friendly_PWM_ADC_GPIO_Application
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.PWM = new System.Windows.Forms.TabPage();
            this.stopPWM = new System.Windows.Forms.PictureBox();
            this.picPWM = new System.Windows.Forms.PictureBox();
            this.freqChange = new System.Windows.Forms.Label();
            this.freqLabel = new System.Windows.Forms.Label();
            this.freq = new System.Windows.Forms.TrackBar();
            this.dutyLabel = new System.Windows.Forms.Label();
            this.duty = new System.Windows.Forms.TrackBar();
            this.ADC = new System.Windows.Forms.TabPage();
            this.stopADC = new System.Windows.Forms.PictureBox();
            this.valueADC2 = new System.Windows.Forms.Label();
            this.valueADC1 = new System.Windows.Forms.Label();
            this.ADC2ON = new System.Windows.Forms.Label();
            this.ADC1ON = new System.Windows.Forms.Label();
            this.picADC = new System.Windows.Forms.PictureBox();
            this.GPIO = new System.Windows.Forms.TabPage();
            this.ledON = new System.Windows.Forms.Label();
            this.ledOFF = new System.Windows.Forms.Label();
            this.picGPIO = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timerPWM = new System.Windows.Forms.Timer();
            this.timerstartPWM = new System.Windows.Forms.Timer();
            this.Tabs.SuspendLayout();
            this.PWM.SuspendLayout();
            this.ADC.SuspendLayout();
            this.GPIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.PWM);
            this.Tabs.Controls.Add(this.ADC);
            this.Tabs.Controls.Add(this.GPIO);
            this.Tabs.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Tabs.Location = new System.Drawing.Point(39, 23);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(690, 402);
            this.Tabs.TabIndex = 0;
            // 
            // PWM
            // 
            this.PWM.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PWM.Controls.Add(this.stopPWM);
            this.PWM.Controls.Add(this.picPWM);
            this.PWM.Controls.Add(this.freqChange);
            this.PWM.Controls.Add(this.freqLabel);
            this.PWM.Controls.Add(this.freq);
            this.PWM.Controls.Add(this.dutyLabel);
            this.PWM.Controls.Add(this.duty);
            this.PWM.Location = new System.Drawing.Point(4, 32);
            this.PWM.Name = "PWM";
            this.PWM.Size = new System.Drawing.Size(682, 366);
            this.PWM.Text = "PWM";
            // 
            // stopPWM
            // 
            this.stopPWM.Image = ((System.Drawing.Image)(resources.GetObject("stopPWM.Image")));
            this.stopPWM.Location = new System.Drawing.Point(579, 17);
            this.stopPWM.Name = "stopPWM";
            this.stopPWM.Size = new System.Drawing.Size(100, 104);
            this.stopPWM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopPWM.Click += new System.EventHandler(this.stopPWM_Click);
            // 
            // picPWM
            // 
            this.picPWM.Image = ((System.Drawing.Image)(resources.GetObject("picPWM.Image")));
            this.picPWM.Location = new System.Drawing.Point(121, 17);
            this.picPWM.Name = "picPWM";
            this.picPWM.Size = new System.Drawing.Size(349, 86);
            this.picPWM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPWM.Click += new System.EventHandler(this.picPWM_Click);
            // 
            // freqChange
            // 
            this.freqChange.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.freqChange.Location = new System.Drawing.Point(192, 329);
            this.freqChange.Name = "freqChange";
            this.freqChange.Size = new System.Drawing.Size(206, 37);
            this.freqChange.Text = "1000 Hz";
            this.freqChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // freqLabel
            // 
            this.freqLabel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.freqLabel.Location = new System.Drawing.Point(212, 212);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(186, 40);
            this.freqLabel.Text = "Frequency";
            // 
            // freq
            // 
            this.freq.LargeChange = 1000;
            this.freq.Location = new System.Drawing.Point(6, 266);
            this.freq.Maximum = 200000;
            this.freq.Minimum = 100;
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(601, 45);
            this.freq.SmallChange = 50000;
            this.freq.TabIndex = 4;
            this.freq.TickFrequency = 1000;
            this.freq.Value = 2500;
            this.freq.ValueChanged += new System.EventHandler(this.freq_ValueChanged);
            // 
            // dutyLabel
            // 
            this.dutyLabel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.dutyLabel.Location = new System.Drawing.Point(212, 106);
            this.dutyLabel.Name = "dutyLabel";
            this.dutyLabel.Size = new System.Drawing.Size(186, 40);
            this.dutyLabel.Text = "Duty Cycle";
            // 
            // duty
            // 
            this.duty.LargeChange = 4;
            this.duty.Location = new System.Drawing.Point(212, 149);
            this.duty.Maximum = 64;
            this.duty.Minimum = 4;
            this.duty.Name = "duty";
            this.duty.Size = new System.Drawing.Size(151, 45);
            this.duty.SmallChange = 4;
            this.duty.TabIndex = 0;
            this.duty.TickFrequency = 4;
            this.duty.Value = 36;
            this.duty.ValueChanged += new System.EventHandler(this.duty_ValueChanged);
            // 
            // ADC
            // 
            this.ADC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ADC.Controls.Add(this.stopADC);
            this.ADC.Controls.Add(this.valueADC2);
            this.ADC.Controls.Add(this.valueADC1);
            this.ADC.Controls.Add(this.ADC2ON);
            this.ADC.Controls.Add(this.ADC1ON);
            this.ADC.Controls.Add(this.picADC);
            this.ADC.Location = new System.Drawing.Point(4, 32);
            this.ADC.Name = "ADC";
            this.ADC.Size = new System.Drawing.Size(682, 366);
            this.ADC.Text = "ADC";
            // 
            // stopADC
            // 
            this.stopADC.Image = ((System.Drawing.Image)(resources.GetObject("stopADC.Image")));
            this.stopADC.Location = new System.Drawing.Point(314, 224);
            this.stopADC.Name = "stopADC";
            this.stopADC.Size = new System.Drawing.Size(100, 104);
            this.stopADC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopADC.Click += new System.EventHandler(this.stopADC_Click);
            // 
            // valueADC2
            // 
            this.valueADC2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.valueADC2.Location = new System.Drawing.Point(420, 239);
            this.valueADC2.Name = "valueADC2";
            this.valueADC2.Size = new System.Drawing.Size(259, 89);
            this.valueADC2.Text = "Value on ADC2";
            this.valueADC2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valueADC1
            // 
            this.valueADC1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.valueADC1.Location = new System.Drawing.Point(44, 239);
            this.valueADC1.Name = "valueADC1";
            this.valueADC1.Size = new System.Drawing.Size(259, 89);
            this.valueADC1.Text = "Value on ADC1";
            this.valueADC1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ADC2ON
            // 
            this.ADC2ON.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.ADC2ON.Location = new System.Drawing.Point(420, 147);
            this.ADC2ON.Name = "ADC2ON";
            this.ADC2ON.Size = new System.Drawing.Size(202, 49);
            this.ADC2ON.Text = "ADC2 -> OFF";
            this.ADC2ON.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ADC1ON
            // 
            this.ADC1ON.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.ADC1ON.Location = new System.Drawing.Point(44, 147);
            this.ADC1ON.Name = "ADC1ON";
            this.ADC1ON.Size = new System.Drawing.Size(202, 49);
            this.ADC1ON.Text = "ADC1 -> OFF";
            this.ADC1ON.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picADC
            // 
            this.picADC.Image = ((System.Drawing.Image)(resources.GetObject("picADC.Image")));
            this.picADC.Location = new System.Drawing.Point(247, 3);
            this.picADC.Name = "picADC";
            this.picADC.Size = new System.Drawing.Size(202, 141);
            this.picADC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picADC.Click += new System.EventHandler(this.picADC_Click);
            // 
            // GPIO
            // 
            this.GPIO.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GPIO.Controls.Add(this.ledON);
            this.GPIO.Controls.Add(this.ledOFF);
            this.GPIO.Controls.Add(this.picGPIO);
            this.GPIO.Location = new System.Drawing.Point(4, 32);
            this.GPIO.Name = "GPIO";
            this.GPIO.Size = new System.Drawing.Size(682, 366);
            this.GPIO.Text = "GPIO";
            // 
            // ledON
            // 
            this.ledON.Location = new System.Drawing.Point(49, 222);
            this.ledON.Name = "ledON";
            this.ledON.Size = new System.Drawing.Size(156, 74);
            this.ledON.Text = "label1";
            // 
            // ledOFF
            // 
            this.ledOFF.Location = new System.Drawing.Point(324, 222);
            this.ledOFF.Name = "ledOFF";
            this.ledOFF.Size = new System.Drawing.Size(156, 74);
            this.ledOFF.Text = "label1";
            // 
            // picGPIO
            // 
            this.picGPIO.Image = ((System.Drawing.Image)(resources.GetObject("picGPIO.Image")));
            this.picGPIO.Location = new System.Drawing.Point(124, 16);
            this.picGPIO.Name = "picGPIO";
            this.picGPIO.Size = new System.Drawing.Size(255, 167);
            this.picGPIO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerPWM
            // 
            this.timerPWM.Interval = 1000;
            this.timerPWM.Tick += new System.EventHandler(this.timerPWM_Tick);
            // 
            // timerstartPWM
            // 
            this.timerstartPWM.Interval = 1000;
            this.timerstartPWM.Tick += new System.EventHandler(this.timerstartPWM_Tick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(827, 472);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GUI";
            this.Tag = "GUIGUIGUI";
            this.Text = "GUI Friendly App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.GUI_Closing);
            this.Tabs.ResumeLayout(false);
            this.PWM.ResumeLayout(false);
            this.ADC.ResumeLayout(false);
            this.GPIO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage PWM;
        private System.Windows.Forms.TabPage ADC;
        private System.Windows.Forms.TabPage GPIO;
        private System.Windows.Forms.TrackBar duty;
        private System.Windows.Forms.Label freqChange;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.TrackBar freq;
        private System.Windows.Forms.Label dutyLabel;
        private System.Windows.Forms.PictureBox picPWM;
        private System.Windows.Forms.PictureBox picGPIO;
        private System.Windows.Forms.Label ledON;
        private System.Windows.Forms.Label ledOFF;
        private System.Windows.Forms.PictureBox picADC;
        private System.Windows.Forms.Label valueADC2;
        private System.Windows.Forms.Label valueADC1;
        private System.Windows.Forms.Label ADC2ON;
        private System.Windows.Forms.Label ADC1ON;
        private System.Windows.Forms.PictureBox stopPWM;
        private System.Windows.Forms.PictureBox stopADC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerPWM;
        private System.Windows.Forms.Timer timerstartPWM;

    }
}

