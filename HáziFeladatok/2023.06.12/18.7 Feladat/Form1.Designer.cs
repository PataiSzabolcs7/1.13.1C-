namespace _18._7_Feladat
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
            this.Eredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Eredmeny
            // 
            this.Eredmeny.BackColor = System.Drawing.SystemColors.Highlight;
            this.Eredmeny.Dock = System.Windows.Forms.DockStyle.Top;
            this.Eredmeny.Location = new System.Drawing.Point(0, 0);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(800, 50);
            this.Eredmeny.TabIndex = 0;
            this.Eredmeny.Text = "label1";
            this.Eredmeny.Click += new System.EventHandler(this.Eredmeny_Click_1);
            this.Eredmeny.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Eredmeny_MouseClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eredmeny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Eredmeny;
    }
}