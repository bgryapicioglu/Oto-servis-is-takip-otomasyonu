using IsTakip.Context;
using IsTakip.Fonksiyonlar;
using IsTakip.IsEmriForm;
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

namespace IsTakip.MusteriForm
{
    public partial class fMusteri : Form
    {
        public fMusteri()
        {
            InitializeComponent();
        }

        readonly DataContext db = new DataContext();
        private void fMusteri_Load(object sender, EventArgs e)
        {
            MusteriSorgu();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tAdi.Text != "" && tSoyadi.Text != "" && tTelefon.Text != "")
            {
                Musteri m = new Musteri();
                m.Adi = tAdi.Text.ToUpper();
                m.Soyadi = tSoyadi.Text.ToUpper();
                m.Telefon = tTelefon.Text;
                m.Eposta = tEposta.Text;
                m.Adres = tAdres.Text;

                db.MusteriS.Add(m);
                db.SaveChanges();

                MusteriSorgu();

                MessageBox.Show("Müşteri Bilgisi Eklendi", "Müşteri Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tAdi.Clear();
                tSoyadi.Clear();
                tTelefon.Clear();
                tEposta.Clear();
                tAdres.Clear();
                tAdi.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Giriniz", "Bilgi Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region METOD

        private void MusteriSorgu()
        {
            using (var dbx = new DataContext())
            {
                gridMusteriler.DataSource = dbx.MusteriS.Take(10).OrderByDescending(x => x.MusteriId).ToList();
            }
            Bicim.GridBicim(gridMusteriler);
        }

        #endregion

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridMusteriler.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridMusteriler.CurrentRow.Cells["MusteriId"].Value);
                fMusteriDuzenle fDuzenle = new fMusteriDuzenle(id);
                fDuzenle.ShowDialog();
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridMusteriler.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridMusteriler.CurrentRow.Cells["MusteriId"].Value);
                DialogResult sonuc = MessageBox.Show("Müşteriyi Silmek İstiyor Musunuz ?", "Müşteri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    using (var dbx = new DataContext())
                    {
                        var musteri = dbx.MusteriS.Find(id);
                        musteri.IsDeleted = true;
                        dbx.SaveChanges();
                        MessageBox.Show("Müşteri Silindi", "Müşteri Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusteriSorgu();
                    }
                }
                else
                {

                }
            }
        }
        private void tAra_TextChanged(object sender, EventArgs e)
        {
            if (tAra.Text.Length > 2)
            {
                using (var dbx = new DataContext())
                {
                    gridMusteriler.DataSource = dbx.MusteriS.Where(x => x.Telefon.Contains(tAra.Text) || x.Soyadi.Contains(tAra.Text)).ToList();
                }
            }
            if (tAra.Text.Length == 0)
            {
                MusteriSorgu();
            }
        }
        private void btnIsEmri_Click(object sender, EventArgs e)
        {
            if (gridMusteriler.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridMusteriler.CurrentRow.Cells["MusteriId"].Value);
                fIsEmriOlustur fisemri = new fIsEmriOlustur(id);
                if (fisemri != null)
                {
                    fisemri.ShowDialog();
                }
            }
        }
    }
}
