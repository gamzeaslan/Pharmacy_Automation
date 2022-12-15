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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //uygulama sayfasından çıkış
            Application.Exit();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            //textbox içindeki bilgileri temizlemek için kullanılır 
            useridtxt.Clear();
            pswordtxt.Clear();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            if(useridtxt.Text=="gamze aslan" && pswordtxt.Text == "1234")
            {
                //eğer başarılı bir giriş gerçekleşirse admin formuna yönlendiricek
                //bunu da o classdan nesne oluturarak sağlarız
                GirisSonrasiSayfa giris = new GirisSonrasiSayfa();
                giris.Show();//diğeer formlara nasıl geçiş yapacağım
                this.Hide();//bu ne işe yarıyor 
            }
            else
            {
                MessageBox.Show("Yanlış şifre veya kullanıcı adı girişi", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tamama basıp kapatmak ve error ikonunu ekranda göstermek için kullandım
            }
        }
    }

        
    }

