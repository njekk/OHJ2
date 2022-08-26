
namespace personapp
{
    partial class FrmInvidual
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(115, 172);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 38);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Palauta";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEtunimi.Location = new System.Drawing.Point(115, 68);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 26);
            this.tbEtunimi.TabIndex = 1;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSukunimi.Location = new System.Drawing.Point(115, 124);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 26);
            this.tbSukunimi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sukunimi";
            // 
            // FrmInvidual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.btnReturn);
            this.Name = "FrmInvidual";
            this.Text = "FrmInvidual";
            this.Load += new System.EventHandler(this.FrmInvidual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}