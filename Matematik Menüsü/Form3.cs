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
    public partial class Form3 : Form
    {
        public Form3()
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
            int çarpım = sayı1 * sayı2;
            textBox3.Text = çarpım.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button2.Text = "HESAPLA";
            textBox1.Text = "   ";
            textBox2.Text = "   ";
            textBox3.Text = "   ";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }
    }
}
