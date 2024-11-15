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
    public partial class fAcıkIsEmirleri : Form
    {
        public fAcıkIsEmirleri()
        {
            InitializeComponent();
        }
        private readonly DataContext db = new DataContext();
        public void fAcıkIsEmirleri_Load(object sender, EventArgs e)
        {
            var acik = db.IsEmris
                .Select(x => new { x.IsEmriID, x.Musteri.Adi, x.Musteri.Soyadi, x.Model.Marka.MarkaAd, x.Model.ModelAd, x.Plaka, x.GelisTarihi, x.Kapali, })
                .Where(x => x.Kapali == false).OrderBy(x => x.GelisTarihi).ToList();
            gridAcıkIsEmirleri.DataSource = acik;
            lSayi.Text = acik.Count.ToString();
            Bicim.GridBicim(gridAcıkIsEmirleri);
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            if (gridAcıkIsEmirleri.SelectedRows.Count>0)
            {
                int isemriid = Convert.ToInt32(gridAcıkIsEmirleri.CurrentRow.Cells["IsEmriID"].Value.ToString());
                fIslemYap f = new fIslemYap(isemriid);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("İş Emri Seçilmedi", "İş Emri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}


