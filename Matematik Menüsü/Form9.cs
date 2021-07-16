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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Text = "HESAPLA";
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;


            label1.ForeColor = Color.DarkOrange;
            label2.ForeColor = Color.DarkOrange;
            label3.ForeColor = Color.DarkOrange;
            label4.ForeColor = Color.DarkOrange;
            label5.ForeColor = Color.DarkOrange;
            label6.ForeColor = Color.DarkOrange;
            label7.ForeColor = Color.DarkOrange;
            label8.ForeColor = Color.DarkOrange;
            label9.ForeColor = Color.DarkOrange;
            label10.ForeColor = Color.DarkOrange;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button3.Visible = true;

            button2.Text = "HESAPLANDI";

            int sayı, renk;
            sayı = Convert.ToInt32(textBox1.Text);
            renk = ForeColor.ToArgb();
            if (sayı % 2 == 0)
                label1.Text = "2'YE BÖLÜNÜR";

            else
                label1.Text = "2'YE BÖLÜNMEZ";
            

            if (sayı % 3 == 0)
                label2.Text = "3'E BÖLÜNÜR";
            else
                label2.Text = "3'E BÖLÜNMEZ";

            if (sayı % 4 == 0)
                label3.Text = "4'E BÖLÜNÜR";
            else
                label3.Text = "4'E BÖLÜNMEZ";

            if (sayı % 5 == 0)
                label4.Text = "5'E BÖLÜNÜR";
            else
                label4.Text = "5'E BÖLÜNMEZ";

            if (sayı % 6 == 0)
                label5.Text = "6'YA BÖLÜNÜR";
            else
                label5.Text = "6'YA BÖLÜNMEZ";

            if (sayı % 7 == 0)
                label6.Text = "7'YE BÖLÜNÜR";
            else
                label6.Text = "7'YE BÖLÜNMEZ";

            if (sayı % 8 == 0)
                label7.Text = "8'E BÖLÜNÜR";
            else
                label7.Text = "8'E BÖLÜNMEZ";

            if (sayı % 9 == 0)
                label8.Text = "9'A BÖLÜNÜR";
            else
                label8.Text = "9'A BÖLÜNMEZ";

            if (sayı % 10 == 0)
                label9.Text = "10'A BÖLÜNÜR";
            else
                label9.Text = "10'A BÖLÜNMEZ";

            if (sayı % 11 == 0)
                label10.Text = "11'E BÖLÜNÜR";
            else
                label10.Text = "11'E BÖLÜNMEZ";


            if (sayı % 2 != 0)
                label1.ForeColor = Color.Black;
            if (sayı % 3 != 0)
                label2.ForeColor = Color.Black;
            if (sayı % 4 != 0)
                label3.ForeColor = Color.Black;
            if (sayı % 5 != 0)
                label4.ForeColor = Color.Black;
            if (sayı % 6 != 0)
                label5.ForeColor = Color.Black;
            if (sayı % 7 != 0)
                label6.ForeColor = Color.Black;
            if (sayı % 8 != 0)
                label7.ForeColor = Color.Black;
            if (sayı % 9 != 0)
                label8.ForeColor = Color.Black;
            if (sayı % 10 != 0)
                label9.ForeColor = Color.Black;
            if (sayı % 11 != 0)
                label10.ForeColor = Color.Black;


        }

        private void Form9_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }
    }
}
