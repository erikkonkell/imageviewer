
namespace imageviewer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedsecTool = new System.Windows.Forms.ToolStripMenuItem();
            this.halfSec = new System.Windows.Forms.ToolStripMenuItem();
            this.OneSec = new System.Windows.Forms.ToolStripMenuItem();
            this.oneAndAHalf = new System.Windows.Forms.ToolStripMenuItem();
            this.TwoSec = new System.Windows.Forms.ToolStripMenuItem();
            this.threeSec = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveSec = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.browserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.browserToolStripMenuItem.Text = "Browser";
            this.browserToolStripMenuItem.Click += new System.EventHandler(this.browserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.randomToolStripMenuItem,
            this.speedsecTool});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.RightClickMenu.Size = new System.Drawing.Size(132, 70);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.CheckOnClick = true;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.CheckOnClick = true;
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // speedsecTool
            // 
            this.speedsecTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halfSec,
            this.OneSec,
            this.oneAndAHalf,
            this.TwoSec,
            this.threeSec,
            this.fiveSec});
            this.speedsecTool.Name = "speedsecTool";
            this.speedsecTool.Size = new System.Drawing.Size(131, 22);
            this.speedsecTool.Text = "Speed(sec)";
            // 
            // halfSec
            // 
            this.halfSec.Name = "halfSec";
            this.halfSec.Size = new System.Drawing.Size(89, 22);
            this.halfSec.Text = "0.5";
            this.halfSec.Click += new System.EventHandler(this.halfSec_Click);
            // 
            // OneSec
            // 
            this.OneSec.Name = "OneSec";
            this.OneSec.Size = new System.Drawing.Size(89, 22);
            this.OneSec.Text = "1";
            this.OneSec.Click += new System.EventHandler(this.OneSec_Click);
            // 
            // oneAndAHalf
            // 
            this.oneAndAHalf.Checked = true;
            this.oneAndAHalf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oneAndAHalf.Name = "oneAndAHalf";
            this.oneAndAHalf.Size = new System.Drawing.Size(89, 22);
            this.oneAndAHalf.Text = "1,5";
            this.oneAndAHalf.Click += new System.EventHandler(this.oneAndAHalf_Click);
            // 
            // TwoSec
            // 
            this.TwoSec.Name = "TwoSec";
            this.TwoSec.Size = new System.Drawing.Size(89, 22);
            this.TwoSec.Text = "2";
            this.TwoSec.Click += new System.EventHandler(this.TwoSec_Click);
            // 
            // threeSec
            // 
            this.threeSec.Name = "threeSec";
            this.threeSec.Size = new System.Drawing.Size(89, 22);
            this.threeSec.Text = "3";
            this.threeSec.Click += new System.EventHandler(this.threeSec_Click);
            // 
            // fiveSec
            // 
            this.fiveSec.Name = "fiveSec";
            this.fiveSec.Size = new System.Drawing.Size(89, 22);
            this.fiveSec.Text = "5";
            this.fiveSec.Click += new System.EventHandler(this.fiveSec_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.ContextMenuStrip = this.RightClickMenu;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedsecTool;
        private System.Windows.Forms.ToolStripMenuItem halfSec;
        private System.Windows.Forms.ToolStripMenuItem OneSec;
        private System.Windows.Forms.ToolStripMenuItem oneAndAHalf;
        private System.Windows.Forms.ToolStripMenuItem TwoSec;
        private System.Windows.Forms.ToolStripMenuItem threeSec;
        private System.Windows.Forms.ToolStripMenuItem fiveSec;
        private System.Windows.Forms.Timer timer;
    }
}

