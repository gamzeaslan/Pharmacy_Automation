using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisSayfasi
{
    public partial class SaticiFirma : Form
    {
        public SaticiFirma()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        GirisSonrasiSayfa giris =new GirisSonrasiSayfa();
        private void button1_Click(object sender, EventArgs e)
        {
            giris.create_admin();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris.create_ilaclar();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris.create_musteriler();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris.create_kullanicilar();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris.create_satislar();
            this.Hide();
        }
    }
}
