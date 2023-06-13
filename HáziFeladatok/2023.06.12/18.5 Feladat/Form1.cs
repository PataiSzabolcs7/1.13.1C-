namespace _18._5_Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Szín_Click(object sender, EventArgs e)
        {

        }

        private void Piros_Scroll(object sender, ScrollEventArgs e)
        {
            Szín.BackColor = Color.FromArgb(Piros.Value, Zöld.Value, Kék.Value);
        }

        private void Zöld_Scroll(object sender, ScrollEventArgs e)
        {
            Szín.BackColor = Color.FromArgb(Piros.Value, Zöld.Value, Kék.Value);
        }

        private void Kék_Scroll(object sender, ScrollEventArgs e)
        {
            Szín.BackColor = Color.FromArgb(Piros.Value, Zöld.Value, Kék.Value);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            Szín.Width = Szín.Height = hScrollBar4.Value; Oldal.Text = hScrollBar4.Value.ToString();
        }
    }
}