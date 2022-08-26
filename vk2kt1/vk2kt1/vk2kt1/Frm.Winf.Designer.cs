
namespace vk2kt1
{
    partial class FrmInf
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.cBTitle = new System.Windows.Forms.ComboBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.dtpDOP = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(30, 21);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(41, 13);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "Etunimi";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(30, 47);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(50, 13);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Sukunimi";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(30, 73);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(67, 13);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Syntymäaika";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Titteli";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(30, 126);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(64, 13);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Aloituspäivä";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(30, 154);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 13);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "Lopetuspäivä";
            // 
            // cBTitle
            // 
            this.cBTitle.FormattingEnabled = true;
            this.cBTitle.Items.AddRange(new object[] {
            "projektityöntekijä",
            "suunnittelija",
            "asiantuntija",
            "johtaja"});
            this.cBTitle.Location = new System.Drawing.Point(104, 99);
            this.cBTitle.Name = "cBTitle";
            this.cBTitle.Size = new System.Drawing.Size(121, 21);
            this.cBTitle.TabIndex = 6;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(104, 21);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(121, 20);
            this.tbFname.TabIndex = 7;
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(104, 47);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(121, 20);
            this.tbSname.TabIndex = 8;
            // 
            // dtpDOP
            // 
            this.dtpDOP.CustomFormat = "dd.MM.yyyy";
            this.dtpDOP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOP.Location = new System.Drawing.Point(104, 73);
            this.dtpDOP.Name = "dtpDOP";
            this.dtpDOP.Size = new System.Drawing.Size(121, 20);
            this.dtpDOP.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd.MM.yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(104, 126);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 20);
            this.dtpStart.TabIndex = 10;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd.MM.yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(104, 154);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInput.Location = new System.Drawing.Point(104, 180);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(121, 38);
            this.btnInput.TabIndex = 12;
            this.btnInput.Text = "Syötä tiedot";
            this.btnInput.UseVisualStyleBackColor = false;
            // 
            // FrmInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(363, 267);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpDOP);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.cBTitle);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Name = "FrmInf";
            this.Text = "Henkilötieto -lomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ComboBox cBTitle;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.DateTimePicker dtpDOP;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnInput;
    }
}

