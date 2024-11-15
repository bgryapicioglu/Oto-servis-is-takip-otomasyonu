using IsTakip.Context;
using Lisans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.Models
{
    public class Kontrol
    {
        DataContext db = new DataContext();
        musteriRapor musteriR = new musteriRapor();

        Lic lic = new Lic();

        public bool kontrolYap()
        {
            bool durum = false;
            if (db.musteriRapors.Count() == 0)
            {
                lisansFormuAc();
            }
            else
            {
                Lic lic = new Lic();
                var musteriFo = db.musteriRapors.First();
                if (lic.tarihCoz(musteriFo.baslangic) < DateTime.Now)
                {
                    musteriFo.baslangic = lic.tarihSifrele(DateTime.Now);
                    db.SaveChanges();
                    durum = true;
                }
                if (lic.tarihKontrol(lic.tarihCoz(musteriFo.baslangic), lic.tarihCoz(musteriFo.bitis)))
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                    lisansFormuAc();
                }
            }
            return durum;
        }

        public void lisansFormuAc()
        {
            Lic lic = new Lic();
            fLisans fl = new fLisans();
            fl.lKontrolNo.Text = lic.ekrandaGoster().ToString();
            fl.Show();
        }

        public void lisansla(string girilenKod)
        {
            int durum = lic.lisansiKontrolEt(girilenKod);
            switch (durum)
            {
                case 0: // GEÇERSİZ LİSANS KODU
                    System.Windows.Forms.MessageBox.Show("LİSANS NUMARASI GEÇERSİZDİR", "LİSANS", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
                case 1:
                    demoOlustur();
                    break;
                case 2:
                    yillikOlustur();
                    break;

                default:
                    break;
            }
        }

        private void musteriRaporEkle(string baslangic, string bitis)
        {
            musteriR.baslangic = baslangic;
            musteriR.bitis = bitis;
            db.musteriRapors.Add(musteriR);
            db.SaveChanges();
        }

        private void musteriRaporGuncelle(string baslangic, string bitis)
        {
            var musteriRaporGuncelle = db.musteriRapors.First();
            musteriRaporGuncelle.baslangic = baslangic;
            musteriRaporGuncelle.bitis = bitis;
            db.SaveChanges();
        }

        private int guvenlikEkliMi()
        {
            return db.musteriRapors.Count();
        }

        private void demoOlustur()
        {
            try
            {
                if (guvenlikEkliMi() == 0)
                {
                    // DB EKLEME İŞLEMİ
                    musteriRaporEkle(lic.tarihSifrele(DateTime.Now), lic.tarihSifrele(lic.demoTarihiOlustur()));
                }
                else
                {
                    // DB GÜNCELLEME İŞLEMİ
                    musteriRaporGuncelle(lic.tarihSifrele(DateTime.Now), lic.tarihSifrele(lic.demoTarihiOlustur()));
                }
                System.Windows.Forms.MessageBox.Show("10 GÜNLÜK DEMO HESABINIZA TANIMLANDI \n PROGRAMI TEKRAR ÇALIŞTIRINIZ", "DEMO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("HATA OLUŞTU", "HATA OLUŞTU", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }


        }

        private void yillikOlustur()
        {
            try
            {
                if (guvenlikEkliMi() == 0)
                {
                    // DB EKLEME İŞLEMİ
                    musteriRaporEkle(lic.tarihSifrele(DateTime.Now), lic.tarihSifrele(lic.yillikTarihOlustur()));
                }
                else
                {
                    // DB GÜNCELLEME İŞLEMİ
                    musteriRaporGuncelle(lic.tarihSifrele(DateTime.Now), lic.tarihSifrele(lic.yillikTarihOlustur()));
                }
                System.Windows.Forms.MessageBox.Show("1 YILLIK LİSANS HESABINIZA TANIMLANDI \n PROGRAMI TEKRAR ÇALIŞTIRINIZ","YILLIK",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                Application.Exit();
            }


            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("HATA OLUŞTU", "HATA OLUŞTU", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }






        }






    }
}
