namespace Pomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hourDisplay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stateColor = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.secondDisplay = new System.Windows.Forms.Label();
            this.minuteDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.option3 = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hourDisplay
            // 
            this.hourDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourDisplay.Location = new System.Drawing.Point(6, 16);
            this.hourDisplay.Name = "hourDisplay";
            this.hourDisplay.Size = new System.Drawing.Size(80, 65);
            this.hourDisplay.TabIndex = 0;
            this.hourDisplay.Text = "00";
            this.hourDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stateColor);
            this.groupBox1.Controls.Add(this.state);
            this.groupBox1.Controls.Add(this.secondDisplay);
            this.groupBox1.Controls.Add(this.minuteDisplay);
            this.groupBox1.Controls.Add(this.hourDisplay);
            this.groupBox1.Location = new System.Drawing.Point(308, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // stateColor
            // 
            this.stateColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateColor.Location = new System.Drawing.Point(176, 100);
            this.stateColor.Name = "stateColor";
            this.stateColor.Size = new System.Drawing.Size(15, 15);
            this.stateColor.TabIndex = 4;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(74, 100);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(96, 13);
            this.state.TabIndex = 3;
            this.state.Text = "Pause / Work time";
            // 
            // secondDisplay
            // 
            this.secondDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDisplay.Location = new System.Drawing.Point(178, 16);
            this.secondDisplay.Name = "secondDisplay";
            this.secondDisplay.Size = new System.Drawing.Size(80, 65);
            this.secondDisplay.TabIndex = 2;
            this.secondDisplay.Text = "00";
            this.secondDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minuteDisplay
            // 
            this.minuteDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minuteDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteDisplay.Location = new System.Drawing.Point(92, 16);
            this.minuteDisplay.Name = "minuteDisplay";
            this.minuteDisplay.Size = new System.Drawing.Size(80, 65);
            this.minuteDisplay.TabIndex = 1;
            this.minuteDisplay.Text = "00";
            this.minuteDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.option3);
            this.groupBox2.Controls.Add(this.option1);
            this.groupBox2.Controls.Add(this.option2);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(18, 104);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(255, 38);
            this.option3.TabIndex = 2;
            this.option3.Text = "Hardcore";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            this.option3.MouseEnter += new System.EventHandler(this.option3_MouseEnter);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(18, 16);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(255, 38);
            this.option1.TabIndex = 0;
            this.option1.Text = "Light";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            this.option1.MouseEnter += new System.EventHandler(this.option1_MouseEnter);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(18, 60);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(255, 38);
            this.option2.TabIndex = 1;
            this.option2.Text = "Medium";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            this.option2.MouseEnter += new System.EventHandler(this.option2_MouseEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.stopButton);
            this.groupBox3.Controls.Add(this.startButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Silver;
            this.stopButton.Location = new System.Drawing.Point(6, 81);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(278, 46);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Silver;
            this.startButton.Location = new System.Drawing.Point(6, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(278, 46);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.Transparent;
            this.infoBox.Controls.Add(this.infoLabel);
            this.infoBox.Location = new System.Drawing.Point(308, 151);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(258, 148);
            this.infoBox.TabIndex = 5;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(7, 20);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(245, 122);
            this.infoLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.infoBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stateColor;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label secondDisplay;
        private System.Windows.Forms.Label minuteDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label infoLabel;
    }
}

