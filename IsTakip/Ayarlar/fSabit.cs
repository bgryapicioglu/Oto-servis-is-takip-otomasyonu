using IsTakip.Context;
using IsTakip.IsEmriForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.Ayarlar
{
    public partial class fSabit : Form
    {
        public fSabit()
        {
            InitializeComponent();
        }
        private readonly DataContext db = new DataContext();
        private void fSabit_Load(object sender, EventArgs e)
        {
            var sabit = db.Sabits.FirstOrDefault();
            if (sabit != null)
            {
                tIsYeriAdi.Text = sabit.isYeriAdi;
                tYetkili.Text = sabit.yetkiliAdiSoyadi;
                tTelefon.Text = sabit.telefon;
                tEposta.Text = sabit.eposta;
                tAdres.Text = sabit.adres;
                tIban1.Text = sabit.iban1;
                tIban2.Text = sabit.iban2;
                tKullanici.Text = sabit.kullaniciAdi;
                tSifre1.Text = sabit.kullaniciSifre;
                tSifre2.Text = sabit.kullaniciSifre;

                nKdvOrani.Value = sabit.kdv;
            }
        }

        private void btnIsYeriKaydet_Click(object sender, EventArgs e)
        {
            if (tIsYeriAdi.Text != "" && tTelefon.Text != "" && tYetkili.Text != "" && tSifre1.Text == tSifre2.Text)
            {
                var sabit = db.Sabits.FirstOrDefault();

                sabit.kullaniciSifre = tSifre1.Text;
                sabit.isYeriAdi = tIsYeriAdi.Text;
                sabit.yetkiliAdiSoyadi = tYetkili.Text;
                sabit.telefon = tTelefon.Text;
                sabit.eposta = tEposta.Text;
                sabit.adres = tAdres.Text;
                sabit.iban1 = tIban1.Text;
                sabit.iban2 = tIban2.Text;
                sabit.kullaniciAdi = tKullanici.Text;

               

                db.SaveChanges();
                MessageBox.Show("Değişiklikler Kaydedildi", "Sabit Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fBaslangic fb = (fBaslangic)Application.OpenForms["fBaslangic"];
                if (fb != null)
                {
                    fb.fBaslangic_Load(null, null);
                }






            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Giriniz", "Sabit Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnKdv_Click(object sender, EventArgs e)
        {
            if (nKdvOrani.Value.ToString() != "")
            {
                var sabit = db.Sabits.FirstOrDefault();
                sabit.kdv = Convert.ToInt16(nKdvOrani.Value);
                db.SaveChanges();

                MessageBox.Show("KDV Oranı Kaydedildi", "Sabit Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Lütfen KDV Giriniz", "Sabit Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // FirstOrDefault her zaman ilk satırın işlemini yapar.

    }
}
