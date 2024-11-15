using IsTakip.Models;
using Lisans;
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
    public partial class fLisans : Form
    {
        public fLisans()
        {
            InitializeComponent();
        }

        private void fLisans_Load(object sender, EventArgs e)
        {
            Lic lic = new Lic();
            lcpuNo.Text = lic.cpuKarakterToplam().ToString();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(tLisansNo.Text != "")
            {
                Kontrol k = new Kontrol();
                k.lisansla(tLisansNo.Text);
            }
        }

    }
}
