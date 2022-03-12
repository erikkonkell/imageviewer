using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace imageviewer
{
    public partial class Form1 : Form
    {
        string filePath;
        string tempFile = "./all_images.txt";
        string[] fileTypes = { ".gif", ".jpg", ".jpeg", ".png",".jpe",   };
        private IList<string> flagImageSources = new List<string>();
        bool play = false;
        bool random = false;
        int index;
        Random rd;
        Image currentImage;
        public Form1()
        {
            InitializeComponent();
            timer.Stop();
            rd = new Random();
            ChangeTimer(1.5f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Images|*.gif;*.jpg;*.jpeg;*.png";
            openFileDialog.ShowDialog();
            
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            filePath = Path.GetDirectoryName(openFileDialog.FileName);
            File.WriteAllLines(tempFile, Directory.GetFiles(filePath));
            flagImageSources.Clear();
            using (StreamReader flagImageSourceReader = new StreamReader(tempFile)) 
            {
                while (!flagImageSourceReader.EndOfStream)
                {
                    string line = flagImageSourceReader.ReadLine();
                    if (fileTypes.Any(x => line.EndsWith(x)))
                        flagImageSources.Add(line);
                }
            }
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            File.Delete(tempFile);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetTime()
        {
            halfSec.Checked = false;
            OneSec.Checked = false;
            oneAndAHalf.Checked = false;
            TwoSec.Checked = false;
            threeSec.Checked = false;
            fiveSec.Checked = false;
        }
        private void halfSec_Click(object sender, EventArgs e)
        {
            resetTime();
            halfSec.Checked = true;
            ChangeTimer(.5f);

        }

        private void OneSec_Click(object sender, EventArgs e)
        {
            resetTime();
            OneSec.Checked = true;
            ChangeTimer(1f);

        }

        private void oneAndAHalf_Click(object sender, EventArgs e)
        {
            resetTime();
            oneAndAHalf.Checked = true;
            ChangeTimer(1.5f);

        }

        private void TwoSec_Click(object sender, EventArgs e)
        {
            resetTime();
            TwoSec.Checked = true;            
            ChangeTimer(2f);

        }

        private void threeSec_Click(object sender, EventArgs e)
        {
            resetTime();
            threeSec.Checked = true;
            ChangeTimer(3f);
        }

        private void fiveSec_Click(object sender, EventArgs e)
        {
            resetTime();
            fiveSec.Checked = true;
            ChangeTimer(5f);
        }
        private void ChangeTimer(double newInterval)
        {
            timer.Stop();
            timer.Interval = (int)(1000 * newInterval);
            if (playToolStripMenuItem.Checked)
                timer.Start();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(playToolStripMenuItem.Checked)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            changeImage();
        }
        private int getNextInedx()
        {
            if(randomToolStripMenuItem.Checked)
                index = rd.Next(flagImageSources.Count);
            else
                index = (index + 1) % flagImageSources.Count;
            return index;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            changeImage();
            resetTime();
        }
        private void changeImage()
        {
            if (currentImage != null)
                currentImage.Dispose();
            currentImage = Image.FromFile(flagImageSources[getNextInedx()]);
            pictureBox1.Image = currentImage;
        }
        public void ResetTimer()
        {
            timer.Stop();
            timer.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F11)
            {

            }
        }
    }
}
