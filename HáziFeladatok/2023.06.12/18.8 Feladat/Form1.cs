using System.Diagnostics;
using System.Windows.Forms;

namespace _18._8_Feladat
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random random = new Random();
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            AUB.Items.Clear();
            A1.Items.Clear();
            B1.Items.Clear();
            AnB.Items.Clear();
            Ab.Items.Clear();
            Ba.Items.Clear();
            for (int i = 0; i < A2.Value; i++)
            {
                do
                {
                    r = random.Next(1, 11);
                }
                while (Bennevan(r));
                
                A1.Items.Add(r);
            }
            for (int i = 0; i < B2.Value; i++)
            {
                do
                {
                    r = random.Next(1, 11);
                }
                while (Bennevan2(r));
                B1.Items.Add(r);
            }
            for (int i = 0; i < B1.Items.Count; i++)
            {
                AUB.Items.Add(B1.Items[i]);
            }
            for (int i = 0; i < A1.Items.Count; i++)
            {
                if (!Bennevan3(A1.Items[i]))
                {
                    AUB.Items.Add(A1.Items[i]);
                }
                else if(Bennevan3(A1.Items[i]))
                {
                    AnB.Items.Add(A1.Items[i]);
                    if (Bennevan4(AnB.Items[i]))
                    {
                        Ab.Items.Add(A1.Items[i]);
                    }
                }

            }
        }
        private bool Bennevan(object r) 
        { 
            for (int i = 0; i < A1.Items.Count; i++) 
                if (A1.Items[i].Equals(r))
                    return true;
            return false; 
        }
        private bool Bennevan2(object r)
        {
            for (int i = 0; i < B1.Items.Count; i++)
                if (B1.Items[i].Equals(r))
                    return true;
            return false;
        }
        private bool Bennevan3(object r)
        {
            for (int i = 0; i < B1.Items.Count; i++)
                if (AUB.Items[i].Equals(r))
                    return true;
            return false;
        }
        private bool Bennevan4(object r)
        {
            for (int i = 0; i < A1.Items.Count; i++)
                if (AnB.Items[i].Equals(r))
                    return true;
            return false;
        }

        private void A2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}