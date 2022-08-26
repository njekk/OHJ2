
namespace vk2kt4
{
    partial class FrmDataGrid
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.cbTarget = new System.Windows.Forms.ComboBox();
            this.chbFunction = new System.Windows.Forms.CheckBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.dgwInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.getname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gettarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getfunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nimi";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(3, 44);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(145, 24);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Mitattava arvo";
            // 
            // cbTarget
            // 
            this.cbTarget.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTarget.FormattingEnabled = true;
            this.cbTarget.Items.AddRange(new object[] {
            "Lämpötila",
            "Kosteus",
            "PH",
            "Tuulen nopeus"});
            this.cbTarget.Location = new System.Drawing.Point(173, 41);
            this.cbTarget.Name = "cbTarget";
            this.cbTarget.Size = new System.Drawing.Size(173, 32);
            this.cbTarget.TabIndex = 3;
            // 
            // chbFunction
            // 
            this.chbFunction.AutoSize = true;
            this.chbFunction.Checked = true;
            this.chbFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFunction.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFunction.Location = new System.Drawing.Point(173, 79);
            this.chbFunction.Name = "chbFunction";
            this.chbFunction.Size = new System.Drawing.Size(145, 28);
            this.chbFunction.TabIndex = 4;
            this.chbFunction.Text = "Toiminnassa";
            this.chbFunction.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(3, 116);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 24);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Sijainti";
            // 
            // cbLocation
            // 
            this.cbLocation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Sisällä",
            "Ulkona",
            "Ulkona suojatusti"});
            this.cbLocation.Location = new System.Drawing.Point(173, 113);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(173, 32);
            this.cbLocation.TabIndex = 5;
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(364, 12);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(100, 100);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Vie";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInput_MouseClick);
            // 
            // dgwInfo
            // 
            this.dgwInfo.AllowUserToAddRows = false;
            this.dgwInfo.AllowUserToDeleteRows = false;
            this.dgwInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgwInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getname,
            this.gettarget,
            this.getfunction,
            this.getlocation});
            this.dgwInfo.Location = new System.Drawing.Point(12, 166);
            this.dgwInfo.Name = "dgwInfo";
            this.dgwInfo.ReadOnly = true;
            this.dgwInfo.Size = new System.Drawing.Size(444, 210);
            this.dgwInfo.TabIndex = 2;
            this.dgwInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInfo_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtbName);
            this.panel1.Controls.Add(this.cbTarget);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.chbFunction);
            this.panel1.Controls.Add(this.lblTarget);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 148);
            this.panel1.TabIndex = 0;
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtbName.Location = new System.Drawing.Point(173, 6);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(173, 32);
            this.txtbName.TabIndex = 2;
            // 
            // getname
            // 
            this.getname.HeaderText = "Nimi";
            this.getname.Name = "getname";
            // 
            // gettarget
            // 
            this.gettarget.HeaderText = "Mitattava arvo";
            this.gettarget.Name = "gettarget";
            // 
            // getfunction
            // 
            this.getfunction.HeaderText = "Toiminnassa";
            this.getfunction.Name = "getfunction";
            // 
            // getlocation
            // 
            this.getlocation.HeaderText = "Sijainti";
            this.getlocation.Name = "getlocation";
            // 
            // FrmDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(472, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwInfo);
            this.Controls.Add(this.btnInput);
            this.Name = "FrmDataGrid";
            this.Text = "Mittaus";
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ComboBox cbTarget;
        private System.Windows.Forms.CheckBox chbFunction;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.DataGridView dgwInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn getname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gettarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn getfunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn getlocation;
    }
}

