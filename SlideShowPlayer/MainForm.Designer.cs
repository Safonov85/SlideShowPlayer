namespace SlideShowPlayer
{
    partial class MainForm
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.PlayStopButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.MSecondsTrackBar = new System.Windows.Forms.TrackBar();
            this.MillisecondsLabel = new System.Windows.Forms.Label();
            this.MilliSecNumberLabel = new System.Windows.Forms.Label();
            this.TimerPlay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MSecondsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // PlayStopButton
            // 
            this.PlayStopButton.BackColor = System.Drawing.Color.LightGreen;
            this.PlayStopButton.Location = new System.Drawing.Point(12, 41);
            this.PlayStopButton.Name = "PlayStopButton";
            this.PlayStopButton.Size = new System.Drawing.Size(75, 61);
            this.PlayStopButton.TabIndex = 1;
            this.PlayStopButton.Text = "PLAY";
            this.PlayStopButton.UseVisualStyleBackColor = false;
            this.PlayStopButton.Click += new System.EventHandler(this.PlayStopButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(93, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(715, 470);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // MSecondsTrackBar
            // 
            this.MSecondsTrackBar.Location = new System.Drawing.Point(12, 108);
            this.MSecondsTrackBar.Maximum = 20;
            this.MSecondsTrackBar.Name = "MSecondsTrackBar";
            this.MSecondsTrackBar.Size = new System.Drawing.Size(75, 45);
            this.MSecondsTrackBar.TabIndex = 3;
            this.MSecondsTrackBar.ValueChanged += new System.EventHandler(this.MSecondsTrackBar_ValueChanged);
            // 
            // MillisecondsLabel
            // 
            this.MillisecondsLabel.AutoSize = true;
            this.MillisecondsLabel.Location = new System.Drawing.Point(19, 140);
            this.MillisecondsLabel.Name = "MillisecondsLabel";
            this.MillisecondsLabel.Size = new System.Drawing.Size(64, 13);
            this.MillisecondsLabel.TabIndex = 4;
            this.MillisecondsLabel.Text = "Milliseconds";
            // 
            // MilliSecNumberLabel
            // 
            this.MilliSecNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilliSecNumberLabel.Location = new System.Drawing.Point(12, 156);
            this.MilliSecNumberLabel.Name = "MilliSecNumberLabel";
            this.MilliSecNumberLabel.Size = new System.Drawing.Size(75, 36);
            this.MilliSecNumberLabel.TabIndex = 5;
            this.MilliSecNumberLabel.Text = "50";
            this.MilliSecNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerPlay
            // 
            this.TimerPlay.Interval = 50;
            this.TimerPlay.Tick += new System.EventHandler(this.TimerPlay_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 497);
            this.Controls.Add(this.MilliSecNumberLabel);
            this.Controls.Add(this.MillisecondsLabel);
            this.Controls.Add(this.MSecondsTrackBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.PlayStopButton);
            this.Controls.Add(this.LoadButton);
            this.Name = "MainForm";
            this.Text = "SlideShow Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MSecondsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button PlayStopButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar MSecondsTrackBar;
        private System.Windows.Forms.Label MillisecondsLabel;
        private System.Windows.Forms.Label MilliSecNumberLabel;
        private System.Windows.Forms.Timer TimerPlay;
    }
}

