using System;
using System.Windows.Forms;

namespace Matematik_Menüsü
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            button2.Text = "HESAPLANDI";
            int sayı1 = Convert.ToInt16(textBox1.Text);
            int sayı2 = Convert.ToInt16(textBox2.Text);
            int fark = sayı1 - sayı2;
            textBox3.Text = fark.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button2.Text = "HESAPLA";
            textBox1.Text = "   ";
            textBox2.Text = "   ";
            textBox3.Text = "   ";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }
    }
}
