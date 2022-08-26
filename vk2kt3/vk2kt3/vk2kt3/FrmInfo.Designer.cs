
namespace vk2kt3
{
    partial class FrmInfo
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
            this.lblSname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.Henkilot = new System.Windows.Forms.ListBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.tbPhnum = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(74, 81);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(87, 31);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "Etunimi";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSname.Location = new System.Drawing.Point(74, 125);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(104, 31);
            this.lblSname.TabIndex = 1;
            this.lblSname.Text = "Sukunimi";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(74, 169);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(118, 31);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Puhelinnro";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(74, 213);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(113, 31);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Lähiosoite";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Location = new System.Drawing.Point(74, 257);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(94, 31);
            this.lblPost.TabIndex = 4;
            this.lblPost.Text = "Postinro";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(74, 301);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(172, 31);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "Postitoimipaikka";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(74, 348);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(139, 31);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Syntymäaika";
            // 
            // Henkilot
            // 
            this.Henkilot.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.Henkilot.FormattingEnabled = true;
            this.Henkilot.ItemHeight = 31;
            this.Henkilot.Location = new System.Drawing.Point(30, 107);
            this.Henkilot.Name = "Henkilot";
            this.Henkilot.Size = new System.Drawing.Size(635, 376);
            this.Henkilot.TabIndex = 0;
            this.Henkilot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Henkilot_MouseClick);
            // 
            // tbFname
            // 
            this.tbFname.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.Location = new System.Drawing.Point(252, 78);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(150, 38);
            this.tbFname.TabIndex = 7;
            // 
            // tbSname
            // 
            this.tbSname.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSname.Location = new System.Drawing.Point(252, 122);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(150, 38);
            this.tbSname.TabIndex = 8;
            // 
            // tbPhnum
            // 
            this.tbPhnum.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhnum.Location = new System.Drawing.Point(252, 166);
            this.tbPhnum.Name = "tbPhnum";
            this.tbPhnum.Size = new System.Drawing.Size(150, 38);
            this.tbPhnum.TabIndex = 9;
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdress.Location = new System.Drawing.Point(252, 210);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(150, 38);
            this.tbAdress.TabIndex = 10;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostalCode.Location = new System.Drawing.Point(252, 254);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(100, 38);
            this.tbPostalCode.TabIndex = 11;
            this.tbPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostalCode_KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(252, 298);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(150, 38);
            this.tbCity.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 38);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.Henkilot);
            this.panel1.Location = new System.Drawing.Point(408, -29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 1053);
            this.panel1.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(252, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 68);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Lisää";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1348, 745);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbPhnum);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblFname);
            this.Name = "FrmInfo";
            this.Text = "Lomake";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ListBox Henkilot;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.TextBox tbPhnum;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
    }
}

