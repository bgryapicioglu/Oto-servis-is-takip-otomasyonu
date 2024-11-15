using IsTakip.Context;
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
    public partial class fBakimTuru : Form
    {
        private int _grupid;
        public fBakimTuru(int grupid)
        {
            _grupid = grupid;
            InitializeComponent();
        }

        private void TurDoldur()
        {
            

            listBakimTuru.DisplayMember = "bakimTuruAdi";
            listBakimTuru.ValueMember = "bakimTuruID";
            using (var db = new DataContext())
            {
                listBakimTuru.DataSource=db.bakimTurus.Where(x=> x.bakimGrubuID==_grupid).OrderBy(x=> x.bakimTuruAdi).ToList();
            }
            
        }
        private void fBakimTuru_Load(object sender, EventArgs e)
        {
            TurDoldur();
            using (var db = new DataContext())
            {
                lgrupadi.Text = db.bakimGrubus.Find(_grupid).bakimGrubuAdi;
            }
        }

        private void btnTuruKaydet_Click(object sender, EventArgs e)
        {
            if (tTurAdi.Text != "")
            {
                using (var db = new DataContext())
                {
                    bakimTuru btr = new bakimTuru();
                    btr.bakimTuruAdi = tTurAdi.Text.ToUpper();
                    btr.IsDeleted = false;
                    btr.bakimGrubuID = _grupid;
                    db.bakimTurus.Add(btr);
                    db.SaveChanges();
                    MessageBox.Show("Bakım Türü Eklendi", "Tür Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tTurAdi.Clear();
                    tTurAdi.Focus();
                    TurDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tür Adı Yazınız", "Tür Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTuruSil_Click(object sender, EventArgs e)
        {
            if (listBakimTuru.SelectedValue!=null)
            {
                int id = Convert.ToInt32(listBakimTuru.SelectedValue);
                using (var db = new DataContext())
                {
                    var grup = db.bakimTurus.Find(id);
                    grup.IsDeleted = true;
                    MessageBox.Show("Silindi");
                    db.SaveChanges();
                    TurDoldur();
                    
                }
            }
            
        }
    }
}
