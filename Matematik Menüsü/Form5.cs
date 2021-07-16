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
    public partial class Form5 : Form
    {
        public Form5()
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
            float sayı1 = Convert.ToInt64(textBox1.Text);
            float sayı2 = Convert.ToInt64(textBox2.Text);
            float bölüm = sayı1 / sayı2;
            textBox3.Text = bölüm.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button2.Text = "HESAPLA";
            textBox1.Text = "   ";
            textBox2.Text = "   ";
            textBox3.Text = "   ";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }
    }
}
