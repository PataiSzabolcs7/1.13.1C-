namespace _18._1_Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Balra_Fel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void Jobbra_Fel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = 0;
        }

        private void Balra_Le_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top= Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void Jobbra_Le_Click(object sender, EventArgs e)
        {
            Left= Screen.PrimaryScreen.Bounds.Width - Width;
            Top= Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}