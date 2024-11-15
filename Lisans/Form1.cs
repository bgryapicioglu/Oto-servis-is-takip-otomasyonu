using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lisans;

namespace Microsoft.Report.Viewer.Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lic lic = new Lic();
            label1.Text = lic.cpuNo() + "\n" + lic.cpuKarakterToplam().ToString();


            DateTime gelenTarih = lic.tarihCoz("GFDTKA"); // 2 gün 7 ay 2026
            var getirSifreliTarih = lic.tarihSifrele(DateTime.Now);
            var kontrolNo = lic.ekrandaGoster();


            var getir = lic.gunler();
            var getir2=lic.aylar();
            var getir3 = lic.yillar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
