namespace AFAIK.GUI
{
    partial class frmMain
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
            this.mainMenuStrup = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.statusLblToolstrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mainMenuStrup.SuspendLayout();
            this.mainStatusBar.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrup
            // 
            this.mainMenuStrup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.mainMenuStrup.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrup.Name = "mainMenuStrup";
            this.mainMenuStrup.Size = new System.Drawing.Size(1038, 24);
            this.mainMenuStrup.TabIndex = 0;
            this.mainMenuStrup.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblToolstrip,
            this.toolStripStatusLabel1});
            this.mainStatusBar.Location = new System.Drawing.Point(0, 524);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.ShowItemToolTips = true;
            this.mainStatusBar.Size = new System.Drawing.Size(1038, 23);
            this.mainStatusBar.TabIndex = 1;
            this.mainStatusBar.Text = "statusStrip1";
            // 
            // statusLblToolstrip
            // 
            this.statusLblToolstrip.Name = "statusLblToolstrip";
            this.statusLblToolstrip.Size = new System.Drawing.Size(37, 18);
            this.statusLblToolstrip.Text = "Bereit";
            this.statusLblToolstrip.ToolTipText = "Neue Befehle können entgegen genommen werden!";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.listView1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(194, 500);
            this.leftPanel.TabIndex = 3;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(838, 24);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 500);
            this.rightPanel.TabIndex = 4;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.richTextBox1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(194, 24);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(644, 500);
            this.centerPanel.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(194, 500);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(644, 500);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 547);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainMenuStrup);
            this.MainMenuStrip = this.mainMenuStrup;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmMain";
            this.mainMenuStrup.ResumeLayout(false);
            this.mainMenuStrup.PerformLayout();
            this.mainStatusBar.ResumeLayout(false);
            this.mainStatusBar.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrup;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusBar;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripStatusLabel statusLblToolstrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripStatusLabel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}