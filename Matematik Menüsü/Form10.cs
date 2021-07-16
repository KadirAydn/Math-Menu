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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            button2.Text = "HESAPLANDI";
            button3.Visible = true;
            int sayı, skare;
            sayı = Convert.ToInt32(textBox1.Text);
            skare = sayı * sayı;
            textBox2.Text = skare.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            button3.Visible = false;
            button2.Text = "HESAPLA";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
