using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Xwt;

namespace SlideShowPlayer
{
    public partial class MainForm : Form
    {
        Graphics graphics;
        Graphics graphicsOverride;
        Color backgroundColor = Color.FromArgb(100, 100, 100);
        List<Image> images = new List<Image>();
        int intervalValue = 50;
        int frame = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // print the picture in pictureBox
        void CreatePicture(Image image)
        {
            //graphics.Clear(backgroundColor);
            graphics = Graphics.FromImage(image);
            graphicsOverride = pictureBox.CreateGraphics();
            //images = new List<Image>();

            double adjustSizeX = image.Width;
            double adjustSizeY = image.Height;
            if (image.Height > 470 && image.Width > 715)
            {
                adjustSizeX = image.Width * 0.2;
                adjustSizeY = image.Height * 0.2;
            }

            graphicsOverride.DrawImage(image, 0, 0, (int)adjustSizeX, (int)adjustSizeY);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SelectFileFromDialog();
        }

        // opens up the file dialog and lets you select the pics
        void SelectFileFromDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Users\\MinDator\\Desktop\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Allow the user to select multiple images.
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "My Image Browser";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Text = this.Text + " (Loading...)";
                    images.Clear();
                    foreach(String file in openFileDialog1.FileNames)
                    {
                        Image imageLoad = Image.FromFile(file);
                        images.Add(imageLoad);
                    }
                    Image imageLoad2 = Image.FromFile(openFileDialog1.FileNames[0]);
                    CreatePicture(imageLoad2);
                    this.Text = "SlideShow Player";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message + ". Please Contact Mikhail Safonov.");
                }
            }
        }

        private void MSecondsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            int valueForInterval = (MSecondsTrackBar.Value + 1) * intervalValue;
            TimerPlay.Interval = valueForInterval;
            MilliSecNumberLabel.Text = valueForInterval.ToString();
        }

        private void TimerPlay_Tick(object sender, EventArgs e)
        {
            CreatePicture(images[frame]);
            frame++;
            if (frame > images.Count - 1)
            {
                TimerPlay.Stop();
                PlayStopButton.BackColor = Color.LightGreen;
                PlayStopButton.Text = "PLAY";
                frame = 0;
            }
        }

        // play/stop button
        private void PlayStopButton_Click(object sender, EventArgs e)
        {
            if(images.Count != 0)
            {
                if (PlayStopButton.Text == "PLAY")
                {
                    TimerPlay.Start();
                    PlayStopButton.BackColor = Color.LightCoral;
                    PlayStopButton.Text = "STOP";
                }
                else
                {
                    TimerPlay.Stop();
                    PlayStopButton.BackColor = Color.LightGreen;
                    PlayStopButton.Text = "PLAY";
                }
            }
            else
            {
                MessageBox.Show("Nothing is loaded. Please Load some Pictures.");
            }
        }
    }
}
