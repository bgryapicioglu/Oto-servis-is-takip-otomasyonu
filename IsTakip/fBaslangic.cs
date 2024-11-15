using IsTakip.Ayarlar;
using IsTakip.Context;
using IsTakip.IsEmriForm;
using IsTakip.MusteriForm;
using IsTakip.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip
{
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }
        private readonly DataContext db = new DataContext();
        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            fMusteri musteri = new fMusteri();
            musteri.ShowDialog();
        }

        private void btnIsEmirleriGetir_Click(object sender, EventArgs e)
        {
            fAcıkIsEmirleri faie = new fAcıkIsEmirleri();
            faie.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            fRaporIsEmri frie = new fRaporIsEmri();
            frie.ShowDialog();
        }

        private void btnBakimGrubu_Click(object sender, EventArgs e)
        {
            fBakimGrubu fbg = new fBakimGrubu();
            fbg.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            fMarka fm = new fMarka();
            fm.ShowDialog();
        }

        private void btnSabit_Click(object sender, EventArgs e)
        {

            fSabit fs = new fSabit();
            fs.ShowDialog();

        }

        private void btnGecmisArama_Click(object sender, EventArgs e)
        {
            fGecmisArama fga = new fGecmisArama();
            fga.ShowDialog();
        }

        public void fBaslangic_Load(object sender, EventArgs e)
        {
            using (var dbx = new DataContext())
            {
                var sabit = dbx.Sabits.FirstOrDefault();
                if (sabit != null)
                {
                    lIsYeriAdi.Text = sabit.isYeriAdi;
                    lYetkiliAdiSoyadi.Text = sabit.yetkiliAdiSoyadi;
                    ltelefon.Text = sabit.telefon;
                    leposta.Text = sabit.eposta;
                    lAdres.Text = sabit.adres;
                    liban1.Text = sabit.iban1;
                    liban2.Text = sabit.iban2;
                }
            }



        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
