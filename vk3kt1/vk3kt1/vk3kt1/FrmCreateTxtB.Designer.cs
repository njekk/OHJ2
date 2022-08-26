
namespace vk3kt1
{
    partial class FrmCreateTxtB
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(81, 78);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(67, 35);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "Nappi";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(81, 119);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(67, 35);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "Toinen Nappi";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // FrmCreateTxtB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "FrmCreateTxtB";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
    }
}

