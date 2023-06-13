using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _18._7_Feladat
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        double atlag;
        int osszeg, db, min = int.MaxValue, max = int.MinValue;

        private void Eredmeny_Click(object sender, EventArgs e)
        {

        }

        private void Eredmeny_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Eredmeny_Click_1(object sender, EventArgs e)
        {

            
        }

        private void Eredmeny_MouseClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            int i = random.Next(100) + 1;
            Label lb = new Label();
            lb.Location = new Point(e.X, e.Y);
            lb.Text = i.ToString();
            lb.AutoSize = true;
            Controls.Add(lb);
            db++;
            osszeg += i;
            atlag = osszeg / (double)db;
            if (min > i)
            {
                min = i;
            }
            if (max < i)
            {
                max = i;
            }
            Eredmeny.Text = String.Format("Darabszám:{0},összeg:{1},átlag:{2}," + "minimum:{3},maximum:{4}.", db, osszeg, atlag, min, max);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}