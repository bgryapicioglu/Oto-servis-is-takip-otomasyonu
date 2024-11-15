using IsTakip.Abstract;
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
    public partial class fMarka : Form
    {
        public fMarka()
        {
            InitializeComponent();
        }

        private readonly IRepository<Marka> rpMarka = new Repository<Marka>();

        private void MarkaDoldur()
        {
            
            gridMarkalar.DataSource = rpMarka.List().Select(s=> new {s.MarkaId,s.MarkaAd }).ToList();
            Bicim.GridBicim(gridMarkalar);
        }

        private void btnMarkaKaydet_Click(object sender, EventArgs e)
        {
            if(tMarkaAdi.Text!="")
            {
                Marka marka = new Marka();
                marka.MarkaAd=tMarkaAdi.Text.ToUpper();
                rpMarka.Insert(marka);
                MarkaDoldur();
            }
        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            if (gridMarkalar.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(gridMarkalar.CurrentRow.Cells["MarkaId"].Value);
                DialogResult result = MessageBox.Show("Markayı Silmek İstiyor Musunuz ?", "Marka Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var marka = rpMarka.GetById(id);
                    marka.IsDeleted = true;
                    rpMarka.Update(marka);
                    MarkaDoldur();
                }
                else
                {

                }
            }
        }

        private void fMarka_Load(object sender, EventArgs e)
        {
            MarkaDoldur();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            if (gridMarkalar.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(gridMarkalar.CurrentRow.Cells["MarkaId"].Value);
                fModel f = new fModel(id);
                f.ShowDialog();
            }
        }
    }
}
