
namespace vk2kt2
{
    partial class FrmPosChance
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
            this.lblX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnChance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(231, 129);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(40, 39);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbX.Location = new System.Drawing.Point(309, 126);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(175, 47);
            this.tbX.TabIndex = 1;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbX_KeyPress);
            this.tbX.Leave += new System.EventHandler(this.tbX_Leave);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblY.Location = new System.Drawing.Point(231, 191);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(40, 39);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbY.Location = new System.Drawing.Point(309, 183);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(175, 47);
            this.tbY.TabIndex = 3;
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbY_KeyPress);
            this.tbY.Leave += new System.EventHandler(this.tbY_Leave);
            // 
            // btnChance
            // 
            this.btnChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.btnChance.Location = new System.Drawing.Point(238, 269);
            this.btnChance.Name = "btnChance";
            this.btnChance.Size = new System.Drawing.Size(246, 54);
            this.btnChance.TabIndex = 4;
            this.btnChance.Text = "Painonappi";
            this.btnChance.UseVisualStyleBackColor = true;
            this.btnChance.Click += new System.EventHandler(this.btnChance_Click);
            // 
            // FrmPosChance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1755, 881);
            this.Controls.Add(this.btnChance);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblX);
            this.Name = "FrmPosChance";
            this.Text = "Paikanvaihto";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmPosChance_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnChance;
    }
}

