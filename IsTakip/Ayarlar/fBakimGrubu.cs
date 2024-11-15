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

namespace IsTakip.Ayarlar
{
    public partial class fBakimGrubu : Form
    {
        public fBakimGrubu()
        {
            InitializeComponent();
        }

        private void GrupDoldur()
        {
            using (var db = new DataContext())
            {
                gridBakimGrubu.DataSource = db.bakimGrubus.OrderBy(x => x.bakimGrubuAdi).Select(x => new { x.bakimGrubuID, x.bakimGrubuAdi }).ToList();
            }
        }



        private void fBakimGrubu_Load(object sender, EventArgs e)
        {
            GrupDoldur();
            Bicim.GridBicim(gridBakimGrubu);
        }

        private void btnBakimKaydet_Click(object sender, EventArgs e)
        {
            if (tBakimAdi.Text != "")
            {
                bakimGrubu bakim = new bakimGrubu();
                bakim.bakimGrubuAdi = tBakimAdi.Text.ToUpper();
                bakim.IsDeleted = false;
                using (var db = new DataContext())
                {
                    db.bakimGrubus.Add(bakim);
                    db.SaveChanges();
                    MessageBox.Show("Bakım Grubu Eklendi", "Grup Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tBakimAdi.Clear();
                    tBakimAdi.Focus();
                    GrupDoldur();

                }
            }
            else
            {
                MessageBox.Show("Lütfen Grup Adı Yazınız", "Grup Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBakimSil_Click(object sender, EventArgs e)
        {
            if (gridBakimGrubu.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridBakimGrubu.CurrentRow.Cells["bakimGrubuID"].Value);
                DialogResult sonuc = MessageBox.Show("Bakım Grubunu Silmek İstiyor Musunuz ?", "Grup Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    using (var dbx = new DataContext())
                    {
                        var bakimGrubu = dbx.bakimGrubus.Find(id);
                        bakimGrubu.IsDeleted = true;
                        dbx.SaveChanges();
                        MessageBox.Show("Bakım Grubu Silindi", "Grup Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GrupDoldur();
                    }
                }
                else
                {

                }
            }
        }

        private void btnBakimTurEkle_Click(object sender, EventArgs e)
        {
            if (gridBakimGrubu.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(gridBakimGrubu.CurrentRow.Cells["bakimGrubuID"].Value);
                fBakimTuru f = new fBakimTuru(id);
                f.ShowDialog();
            }
            

        }
    }
}
