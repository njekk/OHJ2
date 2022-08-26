
namespace personapp
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
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstripTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(140, 178);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(409, 210);
            this.dgvPerson.TabIndex = 5;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(195, 97);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(122, 20);
            this.tbFname.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbFname, "Syötä etunimi");
            this.tbFname.Leave += new System.EventHandler(this.tbFname_Leave);
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(195, 123);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(122, 20);
            this.tbSname.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbSname, "Syötä sukunimi");
            this.tbSname.Leave += new System.EventHandler(this.tbSname_Leave);
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(195, 149);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filwToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filwToolStripMenuItem
            // 
            this.filwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.closeToolStripMenuItem});
            this.filwToolStripMenuItem.Name = "filwToolStripMenuItem";
            this.filwToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filwToolStripMenuItem.Text = "File";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuAdd.Size = new System.Drawing.Size(145, 22);
            this.menuAdd.Text = "Add";
            this.menuAdd.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripTimer,
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolstripTimer
            // 
            this.toolstripTimer.Name = "toolstripTimer";
            this.toolstripTimer.Size = new System.Drawing.Size(33, 17);
            this.toolstripTimer.Text = "Kello";
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(23, 17);
            this.statusStrip.Text = "OK";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 22);
            this.toolStripButton1.Text = "Lisää";
            this.toolStripButton1.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(555, 365);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "-->";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolstripTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTransfer;
    }
}

