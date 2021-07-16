using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Menüsü
{
    public partial class Form6 : Form
    {
        public Form6()
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
            textBox2.Enabled = true;
            button3.Visible = true;
            button2.Text = "HESAPLANDI";
            int sayac = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }
            if (sayac == 0)
            {
                textBox2.Text = "ASAL SAYI";
            }
            else
            {
                textBox2.Text = "ASAL DEĞİL";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            button3.Visible = false;
            button2.Text = "HESAPLA";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            textBox2.Enabled = false;
        }
    }
}
