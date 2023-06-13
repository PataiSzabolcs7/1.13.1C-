namespace _18._5_Feladat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Szín = new System.Windows.Forms.Label();
            this.Zöld = new System.Windows.Forms.HScrollBar();
            this.Piros = new System.Windows.Forms.HScrollBar();
            this.Kék = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.Text = new System.Windows.Forms.Label();
            this.Oldal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Szín
            // 
            this.Szín.BackColor = System.Drawing.SystemColors.Control;
            this.Szín.Location = new System.Drawing.Point(226, 71);
            this.Szín.Name = "Szín";
            this.Szín.Size = new System.Drawing.Size(300, 300);
            this.Szín.TabIndex = 0;
            this.Szín.Click += new System.EventHandler(this.Szín_Click);
            // 
            // Zöld
            // 
            this.Zöld.Location = new System.Drawing.Point(226, 450);
            this.Zöld.Maximum = 254;
            this.Zöld.Name = "Zöld";
            this.Zöld.Size = new System.Drawing.Size(300, 17);
            this.Zöld.TabIndex = 2;
            this.Zöld.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Zöld_Scroll);
            // 
            // Piros
            // 
            this.Piros.Location = new System.Drawing.Point(226, 418);
            this.Piros.Maximum = 254;
            this.Piros.Name = "Piros";
            this.Piros.Size = new System.Drawing.Size(300, 17);
            this.Piros.TabIndex = 3;
            this.Piros.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Piros_Scroll);
            // 
            // Kék
            // 
            this.Kék.Location = new System.Drawing.Point(226, 482);
            this.Kék.Maximum = 254;
            this.Kék.Name = "Kék";
            this.Kék.Size = new System.Drawing.Size(300, 17);
            this.Kék.TabIndex = 4;
            this.Kék.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kék_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(188, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.Location = new System.Drawing.Point(226, 26);
            this.hScrollBar4.Maximum = 310;
            this.hScrollBar4.Minimum = 10;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(300, 17);
            this.hScrollBar4.TabIndex = 8;
            this.hScrollBar4.Value = 10;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text.Location = new System.Drawing.Point(226, 2);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(76, 24);
            this.Text.TabIndex = 9;
            this.Text.Text = "Oldala:";
            // 
            // Oldal
            // 
            this.Oldal.AutoSize = true;
            this.Oldal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Oldal.Location = new System.Drawing.Point(308, 2);
            this.Oldal.Name = "Oldal";
            this.Oldal.Size = new System.Drawing.Size(0, 24);
            this.Oldal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 565);
            this.Controls.Add(this.Oldal);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kék);
            this.Controls.Add(this.Piros);
            this.Controls.Add(this.Zöld);
            this.Controls.Add(this.Szín);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Szín;
        private HScrollBar Zöld;
        private HScrollBar Piros;
        private HScrollBar Kék;
        private Label label1;
        private Label label2;
        private Label label3;
        private HScrollBar hScrollBar4;
        private Label Text;
        private Label Oldal;
    }
}