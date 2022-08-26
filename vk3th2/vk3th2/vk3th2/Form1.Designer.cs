
namespace vk3th2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTuo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLopeta = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbText = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImport = new System.Windows.Forms.ToolStripButton();
            this.tsbReplace = new System.Windows.Forms.ToolStripButton();
            this.tstbRemove = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVie,
            this.tsmTuo,
            this.tsmLopeta});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmVie
            // 
            this.tsmVie.Name = "tsmVie";
            this.tsmVie.Size = new System.Drawing.Size(180, 22);
            this.tsmVie.Text = "Vie";
            this.tsmVie.Click += new System.EventHandler(this.tsmVie_Click);
            // 
            // tsmTuo
            // 
            this.tsmTuo.Name = "tsmTuo";
            this.tsmTuo.Size = new System.Drawing.Size(180, 22);
            this.tsmTuo.Text = "Tuo";
            this.tsmTuo.Click += new System.EventHandler(this.tsmTuo_Click);
            // 
            // tsmLopeta
            // 
            this.tsmLopeta.Name = "tsmLopeta";
            this.tsmLopeta.Size = new System.Drawing.Size(180, 22);
            this.tsmLopeta.Text = "Lopeta";
            this.tsmLopeta.Click += new System.EventHandler(this.tsmLopeta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbText);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2288, 321);
            this.panel1.TabIndex = 1;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(133, 35);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(347, 251);
            this.tbText.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbtnImport,
            this.tstbRemove,
            this.tsbReplace});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Tallenna";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnImport
            // 
            this.tsbtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImport.Image")));
            this.tsbtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImport.Name = "tsbtnImport";
            this.tsbtnImport.Size = new System.Drawing.Size(23, 22);
            this.tsbtnImport.Text = "Lataa";
            this.tsbtnImport.Click += new System.EventHandler(this.tsbtnImport_Click);
            // 
            // tsbReplace
            // 
            this.tsbReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReplace.Image = ((System.Drawing.Image)(resources.GetObject("tsbReplace.Image")));
            this.tsbReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReplace.Name = "tsbReplace";
            this.tsbReplace.Size = new System.Drawing.Size(23, 22);
            this.tsbReplace.Text = "Poista teksti";
            this.tsbReplace.Click += new System.EventHandler(this.tsbReplace_Click);
            // 
            // tstbRemove
            // 
            this.tstbRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbRemove.Name = "tstbRemove";
            this.tstbRemove.Size = new System.Drawing.Size(100, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmVie;
        private System.Windows.Forms.ToolStripMenuItem tsmTuo;
        private System.Windows.Forms.ToolStripMenuItem tsmLopeta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnImport;
        private System.Windows.Forms.ToolStripTextBox tstbRemove;
        private System.Windows.Forms.ToolStripButton tsbReplace;
    }
}

