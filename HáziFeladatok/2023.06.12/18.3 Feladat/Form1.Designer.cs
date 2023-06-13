namespace _18._3_Feladat
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
            this.Egér = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Egér
            // 
            this.Egér.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Egér.Dock = System.Windows.Forms.DockStyle.Top;
            this.Egér.Location = new System.Drawing.Point(0, 0);
            this.Egér.Name = "Egér";
            this.Egér.Size = new System.Drawing.Size(800, 23);
            this.Egér.TabIndex = 0;
            this.Egér.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Egér);
            this.Name = "Form1";
            this.Text = "18.3 Feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Egér;
    }
}