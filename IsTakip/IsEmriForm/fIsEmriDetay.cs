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
    public partial class fIsEmriDetay : Form
    {
        private int _isemriid;
        public fIsEmriDetay(int isemriid)
        {
            InitializeComponent();
            _isemriid = isemriid;
        }
        private readonly DataContext db = new DataContext();
        private void GridDoldur()
        {
            //gridIslemler.DataSource = db.Islemlers.Select(y => new { y.IsEmriID, y.islemTarihi, y.bakimTuruID, y.bakimTuru.bakimTuruAdi, y.Adet, y.birimFiyat, y.toplamFiyat }).Where(x => x.IsEmriID == _isemriid).ToList();
            var islemler = db.Islemlers
                .Select(y => new { y.IslemlerID, y.islemTarihi, y.bakimTuru, y.IsEmriID, y.birimFiyat, y.bakimTuruID, y.bakimTuru.bakimTuruAdi, y.Adet, y.toplamFiyat })
                .Where(X => X.IsEmriID == _isemriid).ToList();

            var diger = db.IsDigers
                .Where(x => x.IsEmriID == _isemriid).ToList();

            List<ortakIslem> ortak = new List<ortakIslem>();
            foreach (var item in islemler)
            {
                ortak.Add(new ortakIslem
                {

                    ID = item.IslemlerID,
                    Adet = item.Adet,
                    IslemTarihi = item.islemTarihi,
                    birimFiyat = item.birimFiyat,
                    toplamFiyat = item.toplamFiyat,

                    digerIslem = false,
                    IslemAdi = item.bakimTuruAdi,
                });
            }

            foreach (var item in diger)
            {
                ortak.Add(new ortakIslem
                {
                    ID = item.IsDigerID,
                    Adet = item.Adet,
                    birimFiyat = item.birimFiyat,
                    toplamFiyat = item.toplamFiyat,
                    IslemTarihi = item.IslemTarihi,
                    digerIslem = true,
                    IslemAdi = item.bakimTuruAdi,
                });
            }
            gridDetay.DataSource = ortak;
            Bicim.GridBicim(gridDetay);
        }
        private void fIsEmriDetay_Load(object sender, EventArgs e)
        {
            var musteriid = db.IsEmris.Find(_isemriid).MusteriId;
            var musteri = db.MusteriS.Find(musteriid);
            this.Text = musteri.Adi + " " + musteri.Soyadi + " " + musteri.Telefon;

            var isemri = db.IsEmris.Find(_isemriid);
            var model = db.Model.Find(isemri.ModelId);

            var marka = db.MarkaS.Find(model.MarkaID);

            tPlaka.Text = isemri.Plaka;
            tSasiNo.Text = isemri.SasiNo;
            tMarka.Text = marka.MarkaAd;
            tModel.Text = model.ModelAd;
            tTelefon.Text = musteri.Telefon;
            tAdres.Text = musteri.Adres;

            decimal alinanUcret = Convert.ToDecimal(isemri.alinanUcret);
            lAlinanUcret.Text = alinanUcret.ToString("C");

            GridDoldur();
        }
    }
}
