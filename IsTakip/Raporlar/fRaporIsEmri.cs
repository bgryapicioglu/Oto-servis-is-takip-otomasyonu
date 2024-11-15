using IsTakip.Context;
using IsTakip.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.Raporlar
{
    public partial class fRaporIsEmri : Form
    {
        public fRaporIsEmri()
        {
            InitializeComponent();
        }
        private readonly DataContext db = new DataContext();
        private void btnAra_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtBaslangic.Value;
            DateTime bitis = dtBitis.Value;

            var isemirleri = db.IsEmris.Select(x => new { x.Kapali, x.Plaka, x.Model.Marka.MarkaAd, x.Model.ModelAd, x.kapatmaTarihi, x.alinanUcret })
                .Where(x => x.kapatmaTarihi >= baslangic && x.kapatmaTarihi <= bitis && x.Kapali == true).ToList();
            gridIsEmriRapor.DataSource = isemirleri;

            Bicim.GridBicim(gridIsEmriRapor);

            decimal toplam = Convert.ToDecimal(isemirleri.Sum(x => x.alinanUcret));
            lToplamGelir.Text = toplam.ToString("C");

            TimeSpan fark = bitis - baslangic;
            int gunSayisi = (int)fark.TotalDays;
            lGunSayisi.Text = " GÜN :  " + gunSayisi.ToString();

            lToplamGelir.Visible = true;
            lGunSayisi.Visible = true;

            
        }

        private void fRaporIsEmri_Load(object sender, EventArgs e)
        {
            Bicim.GridBicim(gridIsEmriRapor);
        }
    }
}
