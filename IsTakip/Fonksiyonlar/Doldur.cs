using IsTakip.Context;
using IsTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.Fonksiyonlar
{
    internal static class Doldur
    {
        private static readonly DataContext db = new DataContext();

        public static void ModelDoldur(ComboBox cmb, int markaid)
        {
            cmb.DisplayMember = "ModelAd";
            cmb.ValueMember = "ModelId";
            cmb.DataSource = db.Model.Where(x => x.MarkaID == markaid).ToList();
        }

        public static void MarkaDoldur(ComboBox cmb)
        {
            cmb.DisplayMember = "MarkaAd";
            cmb.ValueMember = "MarkaId";
            cmb.DataSource = db.MarkaS.ToList();
        }

        public static void YakitTuruDoldur(ComboBox cmb)
        {
            cmb.DisplayMember = "Tur";
            cmb.ValueMember = "yakitTuruID";
            cmb.DataSource = db.yakitTurus.ToList();
        }

        public static void bakimTuruDoldur(ComboBox cmb, int grupid)
        {
            cmb.DisplayMember = "bakimTuruAdi";
            cmb.ValueMember = "bakimTuruID";
            cmb.DataSource = db.bakimTurus.Where(x => x.bakimGrubuID == grupid).OrderBy(x => x.bakimTuruAdi).ToList();
        }

        public static void bakimGrubuDoldur(ComboBox cmb)
        {
            cmb.DisplayMember = "bakimGrubuAdi";
            cmb.ValueMember = "bakimGrubuID";
            cmb.DataSource = db.bakimGrubus.OrderBy(x => x.bakimGrubuAdi).ToList();
        }

        public static Sabit sabitVeriler()
        {
            Sabit sabit = db.Sabits.FirstOrDefault();
            return sabit;
        }

        public static List<ortakIslem> ListOrtakIslem(int isemriid)
        {
            var islemler = db.Islemlers
               .Select(y => new { y.IslemlerID, y.islemTarihi, y.bakimTuru, y.IsEmriID, y.birimFiyat, y.bakimTuruID, y.bakimTuru.bakimTuruAdi, y.Adet, y.toplamFiyat })
               .Where(X => X.IsEmriID == isemriid).ToList();

            var diger = db.IsDigers
                .Where(x => x.IsEmriID == isemriid).ToList();

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
            return ortak;

        }

    }
}
