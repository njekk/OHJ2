
namespace vk4kt1
{
    partial class FrmFile
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
            this.tbOne = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImport = new System.Windows.Forms.ToolStripMenuItem();
            this.pbInfo = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOne
            // 
            this.tbOne.Location = new System.Drawing.Point(215, 101);
            this.tbOne.Name = "tbOne";
            this.tbOne.Size = new System.Drawing.Size(100, 20);
            this.tbOne.TabIndex = 2;
            this.tbOne.TextChanged += new System.EventHandler(this.tbOne_TextChanged);
            this.tbOne.Leave += new System.EventHandler(this.tbOne_Leave);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(134, 98);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Location = new System.Drawing.Point(321, 98);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInput,
            this.tsmImport});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tsmInput
            // 
            this.tsmInput.Name = "tsmInput";
            this.tsmInput.Size = new System.Drawing.Size(94, 22);
            this.tsmInput.Text = "Vie";
            this.tsmInput.Click += new System.EventHandler(this.tsmInput_Click);
            // 
            // tsmImport
            // 
            this.tsmImport.Enabled = false;
            this.tsmImport.Name = "tsmImport";
            this.tsmImport.Size = new System.Drawing.Size(94, 22);
            this.tsmImport.Text = "Tuo";
            this.tsmImport.Click += new System.EventHandler(this.tsmImport_Click);
            // 
            // pbInfo
            // 
            this.pbInfo.Location = new System.Drawing.Point(134, 159);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(262, 23);
            this.pbInfo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(115, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 114);
            this.panel1.TabIndex = 7;
            // 
            // sfd
            // 
            this.sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.sfd.FilterIndex = 2;
            this.sfd.RestoreDirectory = true;
            // 
            // ofd
            // 
            this.ofd.FilterIndex = 2;
            this.ofd.RestoreDirectory = true;
            // 
            // FrmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFile";
            this.Text = "File";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmInput;
        private System.Windows.Forms.ToolStripMenuItem tsmImport;
        private System.Windows.Forms.ProgressBar pbInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnBack;
    }
}

