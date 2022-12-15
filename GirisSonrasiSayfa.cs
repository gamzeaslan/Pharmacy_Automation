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
    public partial class GirisSonrasiSayfa : Form
    {
        public GirisSonrasiSayfa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_admin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            create_satici_firma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            create_ilaclar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            create_musteriler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            create_kullanicilar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            create_satislar();
        }

        //nesne oluşturmak için kuyllanacağım metotları tanımladım burada 
        public void create_satici_firma()
        {
            SaticiFirma satici_firma = new SaticiFirma();
            satici_firma.Show();
            this.Hide();
        }
        public void create_kullanicilar()
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
            this.Hide();
        }
        public void create_ilaclar()
        {

            İlaclar ilaclar = new İlaclar();
            ilaclar.Show();
            this.Hide();
        }
        public void create_satislar()
        {

            Satislar satislar = new Satislar();
            satislar.Show();
            this.Hide();
        }
        public void create_admin()
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
        public void create_musteriler()
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
            this.Hide();
        }

    }
}
