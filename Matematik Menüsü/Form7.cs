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
    public partial class Form7 : Form
    {
        public Form7()
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
            button3.Visible = true;
            button2.Text = "HESAPLANDI";
            double üs, taban, sonuç;
            üs = Convert.ToDouble(üst.Text);
            taban = Convert.ToDouble(alt.Text);
            sonuç = Math.Pow(taban, üs);
            textBox3.Text = sonuç.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button3.Visible = false;
            button2.Text = "HESAPLA";
            üst.Text = "";
            alt.Text = "";
            textBox3.Text = "";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button3.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
