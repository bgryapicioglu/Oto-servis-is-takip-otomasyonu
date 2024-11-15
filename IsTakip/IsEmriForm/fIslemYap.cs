using IsTakip.Context;
using IsTakip.Fonksiyonlar;
using IsTakip.Models;
using IsTakip.Raporlar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IsTakip.IsEmriForm
{
    public partial class fIslemYap : Form
    {
        private int _isemriid;
        public fIslemYap(int isemriid)
        {
            InitializeComponent();
            _isemriid = isemriid;
        }
        private readonly DataContext db = new DataContext();

        private void GridDoldur()
        {
            //gridIslemler.DataSource = db.Islemlers.Select(y => new { y.IsEmriID, y.islemTarihi, y.bakimTuruID, y.bakimTuru.bakimTuruAdi, y.Adet, y.birimFiyat, y.toplamFiyat }).Where(x => x.IsEmriID == _isemriid).ToList();
           


            var genelToplam = Doldur.ListOrtakIslem(_isemriid).Sum(x => x.toplamFiyat);
            lGenelToplam.Text = genelToplam.ToString("C");

            decimal kdv = Doldur.sabitVeriler().kdv;
            decimal kdvliToplam = ((kdv / 100) * genelToplam) + genelToplam;
            lKdvliToplam.Text = kdvliToplam.ToString("C");

            gridIslemler.DataSource = Doldur.ListOrtakIslem(_isemriid);
            Bicim.GridBicim(gridIslemler);
        }

        private void fiyatSonuc()
        {
            if (tAdet.Value.ToString() != "" && tBirimFiyat.Text != "")
            {
                int adet = Convert.ToInt32(tAdet.Value);
                decimal birimFiyat = Convert.ToInt32(tBirimFiyat.Text);
                decimal toplam = (adet * birimFiyat);
                tToplam.Text = toplam.ToString("C");
            }
        }

        private void digerFiyatSonuc()
        {
            if (tDigerAdet.Value.ToString() != "" && tDigerBirimFiyat.Text != "")
            {
                int adet = Convert.ToInt32(tDigerAdet.Value);
                decimal birimFiyat = Convert.ToInt32(tDigerBirimFiyat.Text);
                decimal toplam = (adet * birimFiyat);
                tDigerToplam.Text = toplam.ToString("C");
            }
        }

        private void fIslemYap_Load(object sender, EventArgs e)
        {
            var isemri = db.IsEmris.Find(_isemriid);
            tPlaka.Text = isemri.Plaka.ToString();
            var musteri = db.MusteriS.Find(isemri.MusteriId);
            var model = db.Model.Find(isemri.ModelId);
            tAdiSoyadi.Text = musteri.Adi + " " + musteri.Soyadi;
            var arac = model.ModelAd;
            tArac.Text = arac.ToString();
            Doldur.bakimGrubuDoldur(cmbBakimGrubu);
            GridDoldur();
            lKdv.Text = "% " + Doldur.sabitVeriler().kdv.ToString();

            this.Text = musteri.Adi.ToUpper() + " " + musteri.Soyadi.ToUpper() + " - " + tArac.Text.ToUpper() + " - " + tPlaka.Text.ToUpper();

        }

        private void cmbBakimGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBakimTur.DataSource = null;
            Doldur.bakimTuruDoldur(cmbBakimTur, Convert.ToInt16(cmbBakimGrubu.SelectedValue));
        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            if (cmbBakimTur.Text != "")
            {
                Islemler islemler = new Islemler();
                islemler.bakimTuruID = Convert.ToInt16(cmbBakimTur.SelectedValue);

                int adet = Convert.ToInt16(tAdet.Value);
                islemler.Adet = adet;

                decimal birimFiyat = Convert.ToDecimal(tBirimFiyat.Text);
                islemler.birimFiyat = birimFiyat;

                islemler.toplamFiyat = (adet * birimFiyat);
                islemler.islemTarihi = DateTime.Now;

                islemler.IsEmriID = _isemriid;

                db.Islemlers.Add(islemler);
                db.SaveChanges();
                MessageBox.Show("Eklendi", "Seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();

                tAdet.Value = 1;
                tBirimFiyat.Text = "0";


            }
            else
            {
                MessageBox.Show("Lütfen Bakım Seçilmedi", "Bakım", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDigerKaydet_Click(object sender, EventArgs e)
        {
            if (tDigerIslem.Text != "")
            {
                IsDiger id = new IsDiger();
                id.IsEmriID = _isemriid;
                id.bakimTuruAdi = tDigerIslem.Text.ToUpper();

                int adet = Convert.ToInt16(tDigerAdet.Value);
                id.Adet = adet;

                decimal birimFiyat = Convert.ToDecimal(tDigerBirimFiyat.Text);
                id.birimFiyat = birimFiyat;
                id.toplamFiyat = (adet * birimFiyat);
                id.IslemTarihi = DateTime.Now;

                db.IsDigers.Add(id);
                db.SaveChanges();

                tDigerIslem.Clear();
                tDigerAdet.Value = 1;
                tDigerBirimFiyat.Text = "0";

                MessageBox.Show("Eklendi", "Seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();

            }
        }

        private void sadeceSayi(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            sadeceSayi(e);
        }

        private void tDigerBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            sadeceSayi(e);
        }

        private void tBirimFiyat_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.SelectAll();
        }

        private void tAdet_ValueChanged(object sender, EventArgs e)
        {
            fiyatSonuc();
        }

        private void tBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            fiyatSonuc();
        }

        private void tBirimFiyat_Leave(object sender, EventArgs e)
        {
            fiyatSonuc();
        }

        private void tDigerAdet_ValueChanged(object sender, EventArgs e)
        {
            digerFiyatSonuc();
        }

        private void tDigerBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            digerFiyatSonuc();
        }

        private void tDigerBirimFiyat_Leave(object sender, EventArgs e)

        {
            digerFiyatSonuc();
        }

        private void btnIslemSil_Click(object sender, EventArgs e)
        {
            if (gridIslemler.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridIslemler.CurrentRow.Cells["ID"].Value.ToString());
                bool digerMi = Convert.ToBoolean(gridIslemler.CurrentRow.Cells["digerIslem"].Value.ToString());
                if (digerMi)
                {
                    var diger = db.IsDigers.Find(id);
                    db.IsDigers.Remove(diger);
                    db.SaveChanges();
                    GridDoldur();
                    MessageBox.Show("İşlem Silindi", "İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    var islem = db.Islemlers.Find(id);
                    db.Islemlers.Remove(islem);
                    db.SaveChanges();
                    GridDoldur();
                    MessageBox.Show("İşlem Silindi", "İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tAlinanUcret.Text != "")
            {
                DialogResult result = MessageBox.Show("İş Emri Kapatılsın Mı ?", "İş Emri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    var isemri = db.IsEmris.Find(_isemriid);
                    isemri.Kapali = true;
                    isemri.kapatmaTarihi = DateTime.Now;
                    isemri.alinanUcret = Convert.ToDecimal(tAlinanUcret.Text);
                    db.SaveChanges();

                    fIsEmriRaporGoster frapor = new fIsEmriRaporGoster(_isemriid);
                    frapor.ShowDialog();

                    fAcıkIsEmirleri f = (fAcıkIsEmirleri)Application.OpenForms["fAcıkIsEmirleri"];
                    f.fAcıkIsEmirleri_Load(null, null);
                    this.Hide();



                }

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
