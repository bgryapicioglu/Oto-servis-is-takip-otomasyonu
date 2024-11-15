using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakip.Fonksiyonlar
{
    internal static class Bicim
    {
        public static void GridBicim(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                switch (dgv.Columns[i].HeaderText)
                {
                    case "IsEmriID":
                        dgv.Columns[i].HeaderText = "İŞ EMRİ NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "ortakIslemID":
                        dgv.Columns[i].HeaderText = "ORTAK İŞLEM NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "digerIslem":
                        dgv.Columns[i].HeaderText = "DİĞER İŞLEM NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "ID":
                        dgv.Columns[i].HeaderText = "ID NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "IslemAdi":
                        dgv.Columns[i].HeaderText = "İŞLEM ADI";
                        break;
                    case "IslemTarihi":
                        dgv.Columns[i].HeaderText = "İŞLEM TARİHİ";
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "Adi":
                        dgv.Columns[i].HeaderText = "ADI";
                        break;
                    case "Soyadi":
                        dgv.Columns[i].HeaderText = "SOYADI";
                        break;
                    case "MarkaAd":
                        dgv.Columns[i].HeaderText = "MARKA";
                        break;
                    case "ModelAd":
                        dgv.Columns[i].HeaderText = "MODEL";
                        break;
                    case "Plaka":
                        dgv.Columns[i].HeaderText = "PLAKA";
                        break;
                    case "GelisTarihi":
                        dgv.Columns[i].HeaderText = "GELİŞ TARİHİ";
                        break;
                    case "Kapali":
                        dgv.Columns[i].Visible = false;
                        break;
                    case "IsDeleted":
                        dgv.Columns[i].Visible = false;
                        break;
                    case "MusteriId":
                        dgv.Columns[i].HeaderText = "MÜŞTERİ NO";
                        break;
                    case "Telefon":
                        dgv.Columns[i].HeaderText = "TELEFON";
                        break;
                    case "Eposta":
                        dgv.Columns[i].HeaderText = "E-POSTA";
                        break;
                    case "Adres":
                        dgv.Columns[i].HeaderText = "ADRES";
                        break;
                    case "MarkaId":
                        dgv.Columns[i].HeaderText = "MARKA NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "ModelId":
                        dgv.Columns[i].HeaderText = "MODEL NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "birimFiyat":
                        dgv.Columns[i].HeaderText = "BİRİM FİYAT";
                        dgv.Columns[i].DefaultCellStyle.Format = "C"; // Currency
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "toplamFiyat":
                        dgv.Columns[i].HeaderText = "TOPLAM FİYAT";
                        dgv.Columns[i].DefaultCellStyle.Format = "C"; // Currency
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Adet":
                        dgv.Columns[i].HeaderText = "ADET";
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "bakimTuruID":
                        dgv.Columns[i].HeaderText = "BAKIM TURU NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "bakimTuruAdi":
                        dgv.Columns[i].HeaderText = "BAKIM TÜRÜ";
                        break;
                    case "kapatmaTarihi":
                        dgv.Columns[i].HeaderText = "KAPATMA TARİHİ";
                        break;
                    case "islemTarihi":
                        dgv.Columns[i].HeaderText = "İŞLEM TARİHİ";
                        break;
                    case "alinanUcret":
                        dgv.Columns[i].HeaderText = "ALINAN ÜCRET";
                        dgv.Columns[i].DefaultCellStyle.Format = "C"; // Currency
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Km":
                        dgv.Columns[i].HeaderText = "KM";
                        break;
                    case "Marka":
                        dgv.Columns[i].HeaderText = "MARKA";
                        break;
                    case "Model":
                        dgv.Columns[i].HeaderText = "MODEL";
                        break;
                    case "GelisSebebi":
                        dgv.Columns[i].HeaderText = "GELİŞ SEBEBİ";
                        break;
                    case "bakimGrubuAdi":
                        dgv.Columns[i].HeaderText = "BAKIM GRUBU ADI";
                        break;
                    case "bakimGrubuID":
                        dgv.Columns[i].HeaderText = "BAKIM NO";
                        dgv.Columns[i].Visible = false;
                        break;
                    case "SasiNo":
                        dgv.Columns[i].HeaderText = "ŞASİ NO";
                        break;
                    default: break;
                }
            }

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;

            dgv.RowHeadersVisible = false;
            dgv.ClearSelection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Height = 32;
            }


        }
    }
}
