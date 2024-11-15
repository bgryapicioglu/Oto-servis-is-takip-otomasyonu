using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisans
{
    public class Lic
    {
        public string cpuNo()
        {
            string islemciid = "";
            ManagementObjectSearcher ara = new ManagementObjectSearcher("Select * From WIN32_Processor");
            ManagementObjectCollection obje = ara.Get();
            foreach (ManagementObject item in obje)
            {
                islemciid = item["ProcessorId"].ToString();
            }
            return islemciid;
        }

        public int cpuKarakterToplam()
        {
            int toplam = 0;
            foreach (char item in cpuNo().ToCharArray())
            {
                toplam += (int)item;
            }
            return toplam;
        }

        public string gunKarakter = "KDJSAKLJFKALSJDHFAWCSOEKAUSDTRSLKLPJHGKTYNMBCVASZKPMNMBVHJGFTJRTYPLKE";
        public string ayKarakter = "DJSAKLJFKALWCSOEKPLSDTRL";
        public string yilKarakter = "KLJFKALSOEALSDTRLPJHGCVGFAFDKFAAZJHTYALJMPGKZCCVBNAERTYEFJGMDLVC";

        public bool tarihKontrol(DateTime baslangic, DateTime bitis)
        {
            return baslangic < DateTime.Now && DateTime.Now < bitis;
        }
        public int lisansiKontrolEt(string girilenLisansBilgisi)
        {
            Cursor.Current = Cursors.WaitCursor;

            double girilen = Convert.ToDouble(girilenLisansBilgisi);

            bool demomu = girilen == cpuKarakterToplam() * tarihFonksiyon() * 43;

            bool yillikmi = girilen == cpuKarakterToplam() * tarihFonksiyon() * 47;

            int durum = 0;

            if (demomu)
            {
                durum = 1; // Demo Kurulum İçin 1
            }

            else if (yillikmi)
            {
                durum = 2; // Yıllık Kurulum İçi 2
            }
            else
            {
                durum = 0;
            }
            Cursor.Current = Cursors.Default;
            return durum;
        }

        public DateTime demoTarihiOlustur()
        {
            DateTime tarih = DateTime.Now.AddDays(10);
            return tarih;

        }

        public DateTime yillikTarihOlustur()
        {
            DateTime tarih = DateTime.Now.AddYears(1);
            return tarih;
        }

        public long ekrandaGoster()
        {
            long gosterilecekNo = cpuKarakterToplam() * tarihFonksiyon();
            return gosterilecekNo;
        }

        public long tarihFonksiyon()
        {
            return (DateTime.Now.Day + DateTime.Now.Month) * DateTime.Now.Year;
        }



        public DateTime tarihCoz(string sifreliTarih)
        {
            string strGun = sifreliTarih.Substring(0, 2);
            string strAy = sifreliTarih.Substring(2, 2);
            string strYil = sifreliTarih.Substring(4, 2);

            int gun = gunler().Where(x => x.ad == strGun).FirstOrDefault().numara;
            int ay = aylar().Where(x => x.ad == strAy).FirstOrDefault().numara;
            int yil = yillar().Where(x => x.ad == strYil).FirstOrDefault().numara;

            DateTime tarih = new DateTime(yil, ay, gun);
            return tarih;
        }

        public string tarihSifrele(DateTime tarih)
        {
            int gun = tarih.Day;
            int ay = tarih.Month;
            int yil = tarih.Year;

            string strGun = gunler().Where(x => x.numara == gun).FirstOrDefault().ad;
            string strAy = aylar().Where(x => x.numara == ay).FirstOrDefault().ad;
            string strYil = yillar().Where(x => x.numara == yil).FirstOrDefault().ad;

            string olusanSifreliTarih = strGun + strAy + strYil;
            return olusanSifreliTarih;

        }

        public List<Sablon> gunler()

        {
            List<Sablon> listGun = new List<Sablon>();
            for (int i = 0; i < 31; i++)
            {
                listGun.Add(new Sablon { numara = i + 1, ad = gunKarakter.ToString().Substring(i * 2, 2) });
            }
            return listGun;
        }
        public List<Sablon> aylar()
        {
            List<Sablon> listAy = new List<Sablon>();
            for (int i = 0; i < 12; i++)
            {
                listAy.Add(new Sablon { numara = i + 1, ad = ayKarakter.ToString().Substring(i * 2, 2) });
            }
            return listAy;
        }
        public List<Sablon> yillar()
        {
            List<Sablon> listYil = new List<Sablon>();
            int karakterSayisi = 0;
            for (int i = 2024; i < 2035; i++)
            {
                listYil.Add(new Sablon { numara = i, ad = yilKarakter.ToString().Substring(karakterSayisi * 2, 2) });
                karakterSayisi += 2;
            }
            return listYil;
        }
        public class Sablon
        {
            public int numara { get; set; }

            public string ad { get; set; }
        }


    }
}
