using IsTakip.Context;
using IsTakip.Models;
using Lisans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IsTakip
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        DataContext db = new DataContext();

        private void button1_Click(object sender, EventArgs e)
        {


            var kusi = db.Sabits.FirstOrDefault();

            if (tKullanici.Text == kusi.kullaniciAdi && tSifre.Text == kusi.kullaniciSifre)
            {

                MessageBox.Show("Giriş Başarılı !", "Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kontrol kontrol = new Kontrol();
                if (kontrol.kontrolYap())
                {
                    fBaslangic fb = new fBaslangic();
                    fb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            var sabit = db.Sabits.FirstOrDefault();

            if (sabit.beniHatirla == true)
            {
                checkBox1.Checked = true;
                button1.Focus();
                tKullanici.Text = sabit.kullaniciAdi;
                tSifre.Text = sabit.kullaniciSifre;
                
            }
            else
            {
                checkBox1.Checked = false;
                tKullanici.Clear();
                tSifre.Clear();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var sabit = db.Sabits.FirstOrDefault();

                sabit.beniHatirla = true;
                db.SaveChanges();
            }
            else
            {
                var sabit= db.Sabits.FirstOrDefault();
                sabit.beniHatirla= false;
                db.SaveChanges();
            }

        }
    }
}
