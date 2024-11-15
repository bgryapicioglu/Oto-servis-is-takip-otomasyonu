using IsTakip.Context;
using IsTakip.Fonksiyonlar;
using IsTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.IsEmriForm
{
    public partial class fIsEmriOlustur : Form
    {
        private int _musteriId;
        public fIsEmriOlustur(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
        }
        private readonly DataContext db = new DataContext();
        private void fIsEmriOlustur_Load(object sender, EventArgs e)
        {
            Musteri musteri = db.MusteriS.Find(_musteriId);
            if (musteri != null)
            {
                tAdi.Text = musteri.Adi;
                tSoyadi.Text = musteri.Soyadi;
                tTelefon.Text = musteri.Telefon;
                tEposta.Text = musteri.Eposta;
                tAdres.Text = musteri.Adres;
            }

            Doldur.YakitTuruDoldur(cmbYakit);
            Doldur.MarkaDoldur(cmbMarka);

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int markaid = Convert.ToInt16(cmbMarka.SelectedValue);
            if (markaid > 0)
            {
                Doldur.ModelDoldur(cmbModel, markaid);
            }
        }

        private void btnIsEmriKaydet_Click(object sender, EventArgs e)
        {
            if (tPlaka.Text != "" && tSasiNo.Text != "" && tKm.Text != "" && tModelYili.Text != "")
            {
                IsEmri ie = new IsEmri();
                ie.ModelId = Convert.ToInt32(cmbModel.SelectedValue);
                ie.Plaka = tPlaka.Text.ToUpper();
                ie.SasiNo = tSasiNo.Text.ToUpper();
                ie.Km = Convert.ToInt32(tKm.Text);
                ie.ModelYili = Convert.ToInt32(tModelYili.Text);
                ie.YakitTuruID = Convert.ToInt32(cmbYakit.SelectedValue);
                ie.GelisTarihi = tGelisTarihi.Value;
                ie.GelisSebebi = tGelisSebebi.Text;
                ie.MusteriId = _musteriId;
                db.IsEmris.Add(ie);
                db.SaveChanges();
                this.Close();

                tPlaka.Clear();
                tSasiNo.Clear();
                tKm.Clear();
                tModelYili.Clear();
                tGelisSebebi.Clear();
                


                MessageBox.Show("İş Emri Oluşturuldu", "İş Emri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Giriniz", "Bilgi Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
