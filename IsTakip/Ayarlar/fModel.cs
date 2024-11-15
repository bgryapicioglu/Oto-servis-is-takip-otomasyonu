using IsTakip.Abstract;
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
    public partial class fModel : Form
    {
        private int _markaid;
        public fModel(int markaid)
        {
            _markaid = markaid;
            InitializeComponent();
        }
        private readonly Repository<Model> rpModel = new Repository<Model>();
        private readonly Repository<Marka> rpMarka = new Repository<Marka>();

        private void ModelDoldur()
        {
            gridModeller.DataSource = rpModel.Get(x => x.MarkaID == _markaid).Select(s => new
            {
                s.ModelId,
                s.ModelAd
            }).ToList();
            Bicim.GridBicim(gridModeller);
        }

        private void fModel_Load(object sender, EventArgs e)
        {
            ModelDoldur();
            var marka = rpMarka.GetById(_markaid);
            lMarkaAdi.Text = marka.MarkaAd;

        }

        private void btnModelKaydet_Click(object sender, EventArgs e)
        {
            if (tModelAdi.Text != "")
            {
                Model model = new Model();
                model.ModelAd = tModelAdi.Text.ToUpper();
                model.MarkaID = _markaid;
                rpModel.Insert(model);
                MessageBox.Show("Model Eklendi", "Model Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridModeller.DataSource = rpModel.Get(x => x.MarkaID == _markaid).ToList();
                ModelDoldur();
            }
            else
            {
                MessageBox.Show("Model Adı Yazınız", "Model Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModelSil_Click(object sender, EventArgs e)
        {
            if (gridModeller.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridModeller.CurrentRow.Cells["ModelId"].Value);
                DialogResult sonuc = MessageBox.Show("Modeli Silmek İstiyor Musunuz ?", "Model Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    using (var dbx = new DataContext())
                    {
                        var model = dbx.Model.Find(id);
                        model.IsDeleted = true;
                        dbx.SaveChanges();
                        MessageBox.Show("Model Silindi", "Model Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModelDoldur();
                    }
                }
                else
                {

                }
            }
        }
    }
}
