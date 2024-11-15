using IsTakip.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.MusteriForm
{
    public partial class fMusteriDuzenle : Form
    {
        private int _MusteriId;
        public fMusteriDuzenle(int MusteriId)
        {
            _MusteriId = MusteriId;
            InitializeComponent();
        }

        private void fMusteriGuncelle_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var musteri = db.MusteriS.Find(_MusteriId);
                if (musteri != null)
                {
                    tAdi.Text = musteri.Adi;
                    tSoyadi.Text = musteri.Soyadi;
                    tTelefon.Text = musteri.Telefon;
                    tEposta.Text = musteri.Eposta;
                    tAdres.Text = musteri.Adres;
                }
            }
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            if (tAdi.Text != "" && tSoyadi.Text != "" && tTelefon.Text !="")
            {
                using (var db = new DataContext())
                {
                    var musteri = db.MusteriS.Find(_MusteriId);
                    musteri.Adi = tAdi.Text;
                    musteri.Soyadi = tSoyadi.Text;
                    musteri.Telefon = tTelefon.Text;
                    musteri.Eposta = tEposta.Text;
                    musteri.Adres = tAdres.Text;
                    db.SaveChanges();

                    fMusteri fMusteri = (fMusteri)Application.OpenForms["fMusteri"];
                    fMusteri.tAra.Text = tSoyadi.Text;
                    fMusteri.tAra.Focus();

                    MessageBox.Show("Müşteri Bilgisi Düzenlendi", "Müşteri Düzenlendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tAdi.Clear();
                    tSoyadi.Clear();
                    tTelefon.Clear();
                    tEposta.Clear();
                    tAdres.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Giriniz", "Bilgi Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}  
