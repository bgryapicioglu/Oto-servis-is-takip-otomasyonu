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

namespace IsTakip.IsEmriForm
{
    public partial class fGecmisArama : Form
    {
        public fGecmisArama()
        {
            InitializeComponent();
        }

        private readonly DataContext db = new DataContext();
        private void tAra_TextChanged(object sender, EventArgs e)
        {
            tAra.Text = tAra.Text.ToUpper();
            tAra.SelectionStart = tAra.Text.Length;
            if (tAra.Text.Length > 2)
            {
                string aranacak = tAra.Text;
                var isemri = db.IsEmris.Select(x => new { x.IsEmriID, x.Plaka, x.SasiNo, x.Musteri.Adi, x.Musteri.Soyadi, x.Km, x.Model.Marka.MarkaAd, x.Model.ModelAd, x.GelisTarihi, x.alinanUcret, x.Kapali })
                    .Where(x => (x.Plaka.Contains(aranacak) || x.SasiNo.Contains(aranacak)) && x.Kapali == true).ToList();

                gridGecmis.DataSource = isemri;
                Bicim.GridBicim(gridGecmis);
            }
        }
        private void fGecmisArama_Load(object sender, EventArgs e)
        {

        }
        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            if (gridGecmis.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridGecmis.CurrentRow.Cells["IsEmriID"].Value.ToString());
                fIsEmriDetay f = new fIsEmriDetay(id);
                f.ShowDialog();

            }
        }




    }
}
