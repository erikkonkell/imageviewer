﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WebPWrapper;


namespace imageviewer
{

    public partial class ImageView : Form
    {
        string filePath;
        string tempFile = "./all_images.txt";
        string[] fileTypes = { ".gif", ".jpg", ".jpeg", ".png",".jpe", ".webp",  };
        private List<string> flagImageSources = new List<string>();
        int index;
        bool fullscreen = false;
        Random rd;
        Color noramlColor = Color.DimGray;
        Color fullScreenColor = Color.Black;
        public ImageView()
        {
            InitializeComponent();
            timer.Stop();
            rd = new Random();
            oneAndAHalf.Checked = true;
            ChangeTimer(1.5f);
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Images|*.gif;*.jpg;*.jpeg;*.png;*.webp";
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                File.WriteAllLines(tempFile, Directory.GetFiles(folderBrowserDialog1.SelectedPath));
                flagImageSources.Clear();
                StreamReader flagImageSourceReader = new StreamReader(tempFile);
                while (!flagImageSourceReader.EndOfStream)
                {
                    string line = flagImageSourceReader.ReadLine();
                    if (fileTypes.Any(x => line.EndsWith(x)))
                        flagImageSources.Add(line);
                }
                
                index = 0;
                NextImage();
                File.Delete(tempFile);
            }
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
        private void HalfSec_Click(object sender, EventArgs e)
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

        private void OneAndAHalf_Click(object sender, EventArgs e)
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

        private void ThreeSec_Click(object sender, EventArgs e)
        {
            resetTime();
            threeSec.Checked = true;
            ChangeTimer(3f);
        }

        private void FiveSec_Click(object sender, EventArgs e)
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

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(playToolStripMenuItem.Checked && flagImageSources.Count > 0)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
                playToolStripMenuItem.Checked = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextImage();
        }
        private int GetNextIndex()
        {
            if(randomToolStripMenuItem.Checked)
            {
                rd = new Random();
                index = rd.Next(flagImageSources.Count);
            }
            else
                index = Mod((index + 1), flagImageSources.Count);
            return index;
        }
        private int GetPreviousIndex()
        {
            if (randomToolStripMenuItem.Checked)
            {
                rd = new Random();
                index = rd.Next(flagImageSources.Count);
            }
            else
                index = Mod((index-1),flagImageSources.Count);
            return index;
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            NextImage();
            resetTime();
        }
        private void NextImage()
        {
            Clean();
            string t = "";
            try
            {
                t = flagImageSources[GetNextIndex()];
                SetImage(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(File.Exists(t) ? "File exists." : "File does not exist.");
                NextImage();
            }
        }
        private void SetImage(string path)
        {
            if(Path.GetExtension(path) == ".webp")
            {
                WebP webp = new WebP();                
                pictureBox1.Image = webp.Load(path);
                
            }
            //pictureBox1.Image = Image.FromFile(path);
            else
                pictureBox1.Image = new Bitmap(path);
            Console.WriteLine(path);
        }
        private void Clean()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                GC.Collect();
            }
        }
        private void PreviousImage()
        {
            Clean();
            string t = "";
            try
            {
                t = flagImageSources[GetPreviousIndex()];
                SetImage(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(File.Exists(t) ? "File exists." : "File does not exist.");
                PreviousImage();
            }

        }
        public void ResetTimer()
        {
            timer.Stop();
            timer.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                FullScreen();
            else if (e.KeyCode == Keys.Escape)
                FullScreen(false);
            else if (e.KeyCode == Keys.Space)
                playToolStripMenuItem.PerformClick();
            
            else if (e.KeyCode == Keys.Right && pictureBox1.Image != null)
                NextImage();

            else if (e.KeyCode == Keys.Left && pictureBox1.Image != null)
                PreviousImage();
            
            else if (e.KeyCode == Keys.R)
                randomToolStripMenuItem.Checked = !randomToolStripMenuItem.Checked;

        }
        private void FullScreen()
        {
            if (fullscreen)
            {
                fullscreen = false;
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.WindowState = FormWindowState.Normal;
                menuStrip1.Visible = true;
                pictureBox1.BackColor = noramlColor;
                exitToolStripMenuItem.Visible = false;

            }
            else
            {
                fullscreen = true;
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                menuStrip1.Visible = false;
                exitToolStripMenuItem.Visible = true;
                pictureBox1.BackColor = fullScreenColor;

            }
        }
        private void FullScreen(bool set)
        {
            if (!set)
            {
                fullscreen = false;
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.WindowState = FormWindowState.Normal;
                menuStrip1.Visible = true;
                pictureBox1.BackColor = noramlColor;
            }
            else
            {
                fullscreen = true;
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                menuStrip1.Visible = false;
                pictureBox1.BackColor = fullScreenColor;
            }
        }
        public static int Mod(int x ,int m)
        {
            return (x % m + m) % m;
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Created by Erik Konkell\n2020-03");
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                filePath = Path.GetDirectoryName(openFileDialog.FileName);
                DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(openFileDialog.FileName));
                FileInfo[] files = di.GetFiles().OrderBy(p => p.CreationTime).ToArray();
                Console.WriteLine("");
                InfoTooList(files);
                index = FindIndex(openFileDialog.FileName) - 1;
                NextImage();
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(openFileDialog.FileName));
                filePath = Path.GetDirectoryName(openFileDialog.FileName);
                flagImageSources.Clear();
                FileInfo[] files = di.GetFiles();    
                InfoTooList(files);
                index = FindIndex(openFileDialog.FileName) - 1;
                NextImage();
            }
        }
        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(openFileDialog.FileName));
                filePath = Path.GetDirectoryName(openFileDialog.FileName);
                flagImageSources.Clear();
                FileInfo[] files = di.GetFiles().OrderBy(p => p.Name).ToArray();
                InfoTooList(files);
                index = FindIndex(openFileDialog.FileName) - 1;
                NextImage();
            }
        }

        private void InfoTooList(FileInfo[] fi)
        {
            flagImageSources = new List<string>();
            foreach (var f in fi)
            {
                flagImageSources.Add(filePath + "\\" + f);
            }
        }
        private int FindIndex(string file)
        {
            return flagImageSources.FindIndex(a => a == file); ; 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullScreen(false);
        }
    }
}
