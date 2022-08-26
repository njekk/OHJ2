
namespace Harjoitustyo_Niko_Topi
{
    partial class Tietokanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tietokanta));
            this.dgwInfo = new System.Windows.Forms.DataGridView();
            this.tbFirstnames = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.tbPostalarea = new System.Windows.Forms.TextBox();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblPostnumber = new System.Windows.Forms.Label();
            this.chbUntil = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cbPostalcode = new System.Windows.Forms.ComboBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tbHomeaddress = new System.Windows.Forms.TextBox();
            this.tbStreetaddress = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwInfo
            // 
            this.dgwInfo.AllowUserToAddRows = false;
            this.dgwInfo.AllowUserToDeleteRows = false;
            this.dgwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInfo.Location = new System.Drawing.Point(11, 424);
            this.dgwInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgwInfo.Name = "dgwInfo";
            this.dgwInfo.ReadOnly = true;
            this.dgwInfo.RowHeadersWidth = 51;
            this.dgwInfo.RowTemplate.Height = 24;
            this.dgwInfo.Size = new System.Drawing.Size(1282, 195);
            this.dgwInfo.TabIndex = 0;
            this.dgwInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInfo_CellClick);
            this.dgwInfo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwInfo_ColumnHeaderMouseClick);
            this.dgwInfo.Click += new System.EventHandler(this.dgwInfo_Click);
            // 
            // tbFirstnames
            // 
            this.tbFirstnames.BackColor = System.Drawing.Color.White;
            this.tbFirstnames.Location = new System.Drawing.Point(260, 21);
            this.tbFirstnames.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstnames.Name = "tbFirstnames";
            this.tbFirstnames.Size = new System.Drawing.Size(105, 20);
            this.tbFirstnames.TabIndex = 1;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(260, 59);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(105, 20);
            this.tbSurname.TabIndex = 2;
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(260, 100);
            this.tbNickname.Margin = new System.Windows.Forms.Padding(2);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(105, 20);
            this.tbNickname.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnEnglish);
            this.panel1.Controls.Add(this.tbPostalarea);
            this.panel1.Controls.Add(this.btnFinnish);
            this.panel1.Controls.Add(this.lblCheck);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblEnd);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.cbUnit);
            this.panel1.Controls.Add(this.cbTitle);
            this.panel1.Controls.Add(this.lblPost);
            this.panel1.Controls.Add(this.lblPostnumber);
            this.panel1.Controls.Add(this.chbUntil);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.cbPostalcode);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Controls.Add(this.lblStreet);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblNickname);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblFirstname);
            this.panel1.Controls.Add(this.tbHomeaddress);
            this.panel1.Controls.Add(this.tbStreetaddress);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.tbNickname);
            this.panel1.Controls.Add(this.tbFirstnames);
            this.panel1.Controls.Add(this.tbSurname);
            this.panel1.Location = new System.Drawing.Point(310, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 343);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Image = ((System.Drawing.Image)(resources.GetObject("btnEnglish.Image")));
            this.btnEnglish.Location = new System.Drawing.Point(598, 296);
            this.btnEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(60, 36);
            this.btnEnglish.TabIndex = 28;
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // tbPostalarea
            // 
            this.tbPostalarea.Location = new System.Drawing.Point(260, 305);
            this.tbPostalarea.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostalarea.Name = "tbPostalarea";
            this.tbPostalarea.Size = new System.Drawing.Size(105, 20);
            this.tbPostalarea.TabIndex = 8;
            this.tbPostalarea.TextChanged += new System.EventHandler(this.tbPostalarea_TextChanged);
            // 
            // btnFinnish
            // 
            this.btnFinnish.Enabled = false;
            this.btnFinnish.Image = ((System.Drawing.Image)(resources.GetObject("btnFinnish.Image")));
            this.btnFinnish.Location = new System.Drawing.Point(534, 296);
            this.btnFinnish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(60, 36);
            this.btnFinnish.TabIndex = 29;
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(257, 159);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(0, 13);
            this.lblCheck.TabIndex = 29;
            this.lblCheck.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(577, 221);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 22);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Poista";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(493, 221);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 22);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(397, 180);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(45, 13);
            this.lblUnit.TabIndex = 27;
            this.lblUnit.Text = "Yksikkö";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(397, 143);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 13);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Nimike";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(397, 63);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(78, 13);
            this.lblEnd.TabIndex = 25;
            this.lblEnd.Text = "Päättymispäivä";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(397, 25);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(69, 13);
            this.lblStart.TabIndex = 24;
            this.lblStart.Text = "Alkamispäivä";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(493, 180);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(151, 21);
            this.cbUnit.TabIndex = 13;
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(493, 139);
            this.cbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(151, 21);
            this.cbTitle.TabIndex = 12;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(173, 309);
            this.lblPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(83, 13);
            this.lblPost.TabIndex = 23;
            this.lblPost.Text = "Postitoimipaikka";
            // 
            // lblPostnumber
            // 
            this.lblPostnumber.AutoSize = true;
            this.lblPostnumber.Location = new System.Drawing.Point(173, 265);
            this.lblPostnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostnumber.Name = "lblPostnumber";
            this.lblPostnumber.Size = new System.Drawing.Size(65, 13);
            this.lblPostnumber.TabIndex = 22;
            this.lblPostnumber.Text = "Postinumero";
            // 
            // chbUntil
            // 
            this.chbUntil.AutoSize = true;
            this.chbUntil.Location = new System.Drawing.Point(493, 97);
            this.chbUntil.Margin = new System.Windows.Forms.Padding(2);
            this.chbUntil.Name = "chbUntil";
            this.chbUntil.Size = new System.Drawing.Size(128, 17);
            this.chbUntil.TabIndex = 11;
            this.chbUntil.Text = "Toistaiseksi voimassa";
            this.chbUntil.UseVisualStyleBackColor = true;
            this.chbUntil.Click += new System.EventHandler(this.chbUntil_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd.MM.yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(493, 63);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(151, 20);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.Leave += new System.EventHandler(this.dtpEnd_Leave);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd.MM.yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(493, 19);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(151, 20);
            this.dtpStart.TabIndex = 9;
            this.dtpStart.Leave += new System.EventHandler(this.dtpStart_Leave);
            // 
            // cbPostalcode
            // 
            this.cbPostalcode.FormattingEnabled = true;
            this.cbPostalcode.Location = new System.Drawing.Point(260, 260);
            this.cbPostalcode.Margin = new System.Windows.Forms.Padding(2);
            this.cbPostalcode.MaxDropDownItems = 100;
            this.cbPostalcode.Name = "cbPostalcode";
            this.cbPostalcode.Size = new System.Drawing.Size(105, 21);
            this.cbPostalcode.TabIndex = 7;
            this.cbPostalcode.TextUpdate += new System.EventHandler(this.cbPostalcode_TextUpdate);
            this.cbPostalcode.TextChanged += new System.EventHandler(this.cbPostalcode_TextChanged);
            this.cbPostalcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPostalcode_KeyPress);
            this.cbPostalcode.Leave += new System.EventHandler(this.cbPostalcode_Leave);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(173, 219);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(53, 13);
            this.lblHome.TabIndex = 21;
            this.lblHome.Text = "Kotiosoite";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(173, 177);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 13);
            this.lblStreet.TabIndex = 20;
            this.lblStreet.Text = "Katuosoite";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(173, 143);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Henkilötunnus";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(173, 102);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(66, 13);
            this.lblNickname.TabIndex = 18;
            this.lblNickname.Text = "Kutsumanimi";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(173, 63);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(50, 13);
            this.lblSurname.TabIndex = 17;
            this.lblSurname.Text = "Sukunimi";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(173, 23);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(48, 13);
            this.lblFirstname.TabIndex = 16;
            this.lblFirstname.Text = "Etunimet";
            // 
            // tbHomeaddress
            // 
            this.tbHomeaddress.Location = new System.Drawing.Point(260, 215);
            this.tbHomeaddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbHomeaddress.Name = "tbHomeaddress";
            this.tbHomeaddress.Size = new System.Drawing.Size(105, 20);
            this.tbHomeaddress.TabIndex = 6;
            // 
            // tbStreetaddress
            // 
            this.tbStreetaddress.Location = new System.Drawing.Point(260, 175);
            this.tbStreetaddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbStreetaddress.Name = "tbStreetaddress";
            this.tbStreetaddress.Size = new System.Drawing.Size(105, 20);
            this.tbStreetaddress.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(260, 139);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(105, 20);
            this.tbID.TabIndex = 4;
            this.tbID.Leave += new System.EventHandler(this.tbID_Leave);
            // 
            // menuFile
            // 
            this.menuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuFile.Size = new System.Drawing.Size(1390, 24);
            this.menuFile.TabIndex = 5;
            this.menuFile.Text = "Tiedost";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripSave,
            this.stripDelete});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // stripSave
            // 
            this.stripSave.Name = "stripSave";
            this.stripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stripSave.Size = new System.Drawing.Size(157, 22);
            this.stripSave.Text = "Tallenna";
            this.stripSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // stripDelete
            // 
            this.stripDelete.Name = "stripDelete";
            this.stripDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.stripDelete.Size = new System.Drawing.Size(157, 22);
            this.stripDelete.Text = "Poista";
            this.stripDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Tietokanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1390, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwInfo);
            this.Controls.Add(this.menuFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tietokanta";
            this.Text = "Tietokanta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tietokanta_FormClosing);
            this.Load += new System.EventHandler(this.Tietokanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInfo;
        private System.Windows.Forms.TextBox tbFirstnames;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblPostnumber;
        private System.Windows.Forms.CheckBox chbUntil;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cbPostalcode;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox tbHomeaddress;
        private System.Windows.Forms.TextBox tbStreetaddress;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripSave;
        private System.Windows.Forms.ToolStripMenuItem stripDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbPostalarea;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnEnglish;
    }
}

