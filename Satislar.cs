﻿using System;
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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        GirisSonrasiSayfa giris=new GirisSonrasiSayfa();
        private void button1_Click(object sender, EventArgs e)
        {
            giris.create_admin();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris.create_satici_firma();
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
    }
}
