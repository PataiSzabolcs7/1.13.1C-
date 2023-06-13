namespace _18._4_Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Width += 10; 
            Height += 10;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Width -= 10;
            Height -= 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0) 
            {
                Opacity += 0.1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Opacity <= 1.0 && Opacity > 0.2)
            {
                Opacity -= 0.1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2; 
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Le.Visible = TeljesenLe.Visible =
            Fel.Visible = TeljesenFel.Visible =
            Balra.Visible = TeljesenBal.Visible =
            Jobbra.Visible = TeljesenJobb.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Le.Visible = TeljesenLe.Visible = false;
            Fel.Visible = TeljesenFel.Visible = Balra.Visible = TeljesenBal.Visible = Jobbra.Visible = TeljesenJobb.Visible = true;
        }

        private void Fel_Click(object sender, EventArgs e)
        {
            if (Top - 10 > 0) 
            { 
                Top -= 10; 
            } 
            else 
            { 
                Top = 0; 
                Fel.Visible = TeljesenFel.Visible = false; 
            }
            Le.Visible = TeljesenLe.Visible = true;
        }

        private void TeljesenFel_Click(object sender, EventArgs e)
        {
            Top = 0;
            Fel.Visible = TeljesenFel.Visible = false;
            Le.Visible = TeljesenLe.Visible = Balra.Visible = TeljesenBal.Visible = Jobbra.Visible = TeljesenJobb.Visible = true;
        }

        private void TeljesenBal_Click(object sender, EventArgs e)
        {
            Left = 0;
            Le.Visible = TeljesenLe.Visible = true;
            Fel.Visible = TeljesenFel.Visible = true;
            Balra.Visible = TeljesenBal.Visible = false;
            Jobbra.Visible = TeljesenJobb.Visible = true;
        }

        private void TeljesenJobb_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Le.Visible = TeljesenLe.Visible = true;
            Fel.Visible = TeljesenFel.Visible = true;
            Balra.Visible = TeljesenBal.Visible = true;
            Jobbra.Visible = TeljesenJobb.Visible = false;
        }

        private void Balra_Click(object sender, EventArgs e)
        {
            if (Left - 10 > 0)
            {
                Left -= 10;
            }
            else
            {
                Left = 0;
                Balra.Visible = TeljesenBal.Visible = false;
            }
        }

        private void Jobbra_Click(object sender, EventArgs e)
        {
        }
    }
}