using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Matematik_Menüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Çıkar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void BtnÇarp_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void ebob_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void ekok_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void BtnÇiftmi_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void BtnTamBölen_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }

        private void BtnKareAl_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
            this.Hide();
        }

        private void çıkış_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ---UYGULAMADAN ÇIKIYORSUNUZ---", "YİNE BEKLERİZ  :)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();


            

        }

        private void Hakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Kadir Aydın tarafından yapılmıştır.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();
            this.Hide();
        }
    }
}
