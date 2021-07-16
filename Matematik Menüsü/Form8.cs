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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            button3.Visible = true;
            button2.Text = "HESAPLANDI";
            int sayı1 = Convert.ToInt32(textBox1.Text);
            if (sayı1 % 2 == 0)
            {
                textBox2.Text = "ÇİFT SAYI";
            }
            else
            {
                textBox2.Text = "TEK SAYI";
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

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
