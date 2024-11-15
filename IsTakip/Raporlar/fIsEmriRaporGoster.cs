using IsTakip.Context;
using IsTakip.Fonksiyonlar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.Raporlar
{
    public partial class fIsEmriRaporGoster : Form
    {
        private int _isemriid;
        public fIsEmriRaporGoster(int isemriid)
        {
            InitializeComponent();
            _isemriid = isemriid;
        }
        private readonly DataContext db = new DataContext();
        private void fIsEmriRaporGoster_Load(object sender, EventArgs e)
        {

            var isemri = db.IsEmris.Find(_isemriid);
            var musteri = db.MusteriS.Find(isemri.MusteriId);
            var model = db.Model.Find(isemri.ModelId);
            var marka = db.MarkaS.FirstOrDefault(x => x.MarkaId == model.MarkaID);
            var sabit = db.Sabits.FirstOrDefault();

            ReportParameter[] param = new ReportParameter[17];
            param[0] = new ReportParameter("IsYeriAdi", sabit.isYeriAdi);
            param[1] = new ReportParameter("gelmeSebebi", isemri.GelisSebebi);

            param[2] = new ReportParameter("adiSoyadi", musteri.Adi + "  " + musteri.Soyadi);
            param[3] = new ReportParameter("IsYeriAdres", sabit.adres);
            param[4] = new ReportParameter("IsYeriTelefon", sabit.telefon);
            param[5] = new ReportParameter("IsYeriIban", sabit.iban1 + " & " + sabit.iban2);

            param[6] = new ReportParameter("GelisTarihi", isemri.GelisTarihi.ToShortDateString());
            param[7] = new ReportParameter("GelisSebebi", isemri.GelisSebebi);
            param[8] = new ReportParameter("AlinanUcret", isemri.alinanUcret.ToString());
            param[9] = new ReportParameter("kdvTutari", sabit.kdv.ToString());
            param[10] = new ReportParameter("markaAd", marka.MarkaAd);
            param[11] = new ReportParameter("modelAd", model.ModelAd);
            param[12] = new ReportParameter("kmBilgi", isemri.Km.ToString());
            param[13] = new ReportParameter("plakaBilgi", isemri.Plaka);
            param[14] = new ReportParameter("sasiBilgi", isemri.SasiNo);
            param[15] = new ReportParameter("musteriTelefon", musteri.Telefon);
            param[16] = new ReportParameter("musteriAdres", musteri.Adres);






            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;

            localReport.ReportPath = Application.StartupPath + "\\Raporlar\\rpIsEmri.rdlc";
            localReport.DataSources.Add(new ReportDataSource("dsIsemri", Doldur.ListOrtakIslem(_isemriid)));
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();




        }
    }
}
