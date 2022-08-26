
namespace vk44kt2
{
    partial class FrmGame
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHowClose = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTxt,
            this.tsslCounter,
            this.tsslHowClose});
            this.statusStrip1.Location = new System.Drawing.Point(0, 235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(450, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTxt
            // 
            this.tsslTxt.BackColor = System.Drawing.SystemColors.Control;
            this.tsslTxt.Name = "tsslTxt";
            this.tsslTxt.Size = new System.Drawing.Size(104, 17);
            this.tsslTxt.Text = "Arvauksien määrä:";
            // 
            // tsslCounter
            // 
            this.tsslCounter.BackColor = System.Drawing.SystemColors.Control;
            this.tsslCounter.Name = "tsslCounter";
            this.tsslCounter.Size = new System.Drawing.Size(13, 17);
            this.tsslCounter.Text = "0";
            // 
            // tsslHowClose
            // 
            this.tsslHowClose.BackColor = System.Drawing.SystemColors.Control;
            this.tsslHowClose.Name = "tsslHowClose";
            this.tsslHowClose.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnGuess);
            this.panel1.Controls.Add(this.tbGuess);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(26, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Arvattava luku";
            // 
            // tbGuess
            // 
            this.tbGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuess.Location = new System.Drawing.Point(193, 56);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 29);
            this.tbGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(193, 106);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 38);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Arvaa";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGuess_MouseClick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGame";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTxt;
        private System.Windows.Forms.ToolStripStatusLabel tsslCounter;
        private System.Windows.Forms.ToolStripStatusLabel tsslHowClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Label lbl1;
    }
}

