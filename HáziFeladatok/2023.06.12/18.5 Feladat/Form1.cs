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

        private void Sz�n_Click(object sender, EventArgs e)
        {

        }

        private void Piros_Scroll(object sender, ScrollEventArgs e)
        {
            Sz�n.BackColor = Color.FromArgb(Piros.Value, Z�ld.Value, K�k.Value);
        }

        private void Z�ld_Scroll(object sender, ScrollEventArgs e)
        {
            Sz�n.BackColor = Color.FromArgb(Piros.Value, Z�ld.Value, K�k.Value);
        }

        private void K�k_Scroll(object sender, ScrollEventArgs e)
        {
            Sz�n.BackColor = Color.FromArgb(Piros.Value, Z�ld.Value, K�k.Value);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            Sz�n.Width = Sz�n.Height = hScrollBar4.Value; Oldal.Text = hScrollBar4.Value.ToString();
        }
    }
}