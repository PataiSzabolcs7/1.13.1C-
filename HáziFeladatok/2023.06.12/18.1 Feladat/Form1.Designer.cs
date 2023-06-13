namespace _18._1_Feladat
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
            this.Balra_Fel = new System.Windows.Forms.Button();
            this.Jobbra_Fel = new System.Windows.Forms.Button();
            this.Balra_Le = new System.Windows.Forms.Button();
            this.Jobbra_Le = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Balra_Fel
            // 
            this.Balra_Fel.AutoSize = true;
            this.Balra_Fel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Balra_Fel.Location = new System.Drawing.Point(179, 113);
            this.Balra_Fel.Name = "Balra_Fel";
            this.Balra_Fel.Size = new System.Drawing.Size(120, 35);
            this.Balra_Fel.TabIndex = 0;
            this.Balra_Fel.Text = "Balra, Fel";
            this.Balra_Fel.UseVisualStyleBackColor = true;
            this.Balra_Fel.Click += new System.EventHandler(this.Balra_Fel_Click);
            // 
            // Jobbra_Fel
            // 
            this.Jobbra_Fel.AutoSize = true;
            this.Jobbra_Fel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Jobbra_Fel.Location = new System.Drawing.Point(460, 113);
            this.Jobbra_Fel.Name = "Jobbra_Fel";
            this.Jobbra_Fel.Size = new System.Drawing.Size(120, 35);
            this.Jobbra_Fel.TabIndex = 1;
            this.Jobbra_Fel.Text = "Jobbra, Fel";
            this.Jobbra_Fel.UseVisualStyleBackColor = true;
            this.Jobbra_Fel.Click += new System.EventHandler(this.Jobbra_Fel_Click);
            // 
            // Balra_Le
            // 
            this.Balra_Le.AutoSize = true;
            this.Balra_Le.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Balra_Le.Location = new System.Drawing.Point(179, 202);
            this.Balra_Le.Name = "Balra_Le";
            this.Balra_Le.Size = new System.Drawing.Size(120, 35);
            this.Balra_Le.TabIndex = 2;
            this.Balra_Le.Text = "Balra, Le";
            this.Balra_Le.UseVisualStyleBackColor = true;
            this.Balra_Le.Click += new System.EventHandler(this.Balra_Le_Click);
            // 
            // Jobbra_Le
            // 
            this.Jobbra_Le.AutoSize = true;
            this.Jobbra_Le.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Jobbra_Le.Location = new System.Drawing.Point(466, 202);
            this.Jobbra_Le.Name = "Jobbra_Le";
            this.Jobbra_Le.Size = new System.Drawing.Size(120, 35);
            this.Jobbra_Le.TabIndex = 3;
            this.Jobbra_Le.Text = "Jobbra, Le";
            this.Jobbra_Le.UseVisualStyleBackColor = true;
            this.Jobbra_Le.Click += new System.EventHandler(this.Jobbra_Le_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jobbra_Le);
            this.Controls.Add(this.Balra_Le);
            this.Controls.Add(this.Jobbra_Fel);
            this.Controls.Add(this.Balra_Fel);
            this.Name = "Form1";
            this.Text = "18.1 Feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Balra_Fel;
        private Button Jobbra_Fel;
        private Button Balra_Le;
        private Button Jobbra_Le;
    }
}