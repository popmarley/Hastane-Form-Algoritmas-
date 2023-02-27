using Hastane.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.UI
{
    public partial class FrmGunSonu : Form
    {
        private List<Hasta> hastalarimiz;
        private List<Bolum> bolums;
        private List<Doktor> tumDoktorlar;

        public FrmGunSonu()
        {
            InitializeComponent();
        }
        public FrmGunSonu(string hede) : this()
        {

        }

        public FrmGunSonu(List<Hasta> hastalarimiz, List<Bolum> bolums, List<Doktor> tumDoktorlar) : this("")
        {
            this.hastalarimiz = hastalarimiz;
            this.bolums = bolums;
            this.tumDoktorlar = tumDoktorlar;
            //  InitializeComponent();
        }

        private void FrmGunSonu_Load(object sender, EventArgs e)
        {
            //foreach
            cmbBolumler.DataSource = bolums;

            int sayac = 1;

            foreach (Hasta item in hastalarimiz)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (sayac++).ToString();
                li.SubItems.Add(item.RandevuTarihi);
                li.SubItems.Add(item.AdSoyad);
                li.SubItems.Add(item.Doktor.DoktorunBolumu.BolumunAdi);
                li.SubItems.Add(item.Doktor.AdSoyad);
                li.Tag = item;
                lstHastalar.Items.Add(li);
            }


        }
        /// <summary>
        /// cmb den seçim yapmazsa ??
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBul_Click(object sender, EventArgs e)
        {
            Bolum secilenBolum = cmbBolumler.SelectedItem as Bolum;

            lstHastalar.Items.Clear();
            int sayac = 1;
            foreach (Hasta item in hastalarimiz)
            {
                //equls,ref equals
                if (item.Doktor.DoktorunBolumu.BolumunAdi == secilenBolum.BolumunAdi)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = (sayac++).ToString();
                    li.SubItems.Add(item.RandevuTarihi);
                    li.SubItems.Add(item.AdSoyad);
                    li.SubItems.Add(item.Doktor.DoktorunBolumu.BolumunAdi);
                    li.SubItems.Add(item.Doktor.AdSoyad);
                    li.Tag = item;
                    lstHastalar.Items.Add(li);
                }

            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranilanKelime = txtAra.Text;

            lstHastalar.Items.Clear();
            int sayac = 1;
            foreach (Hasta item in hastalarimiz)
            {
                //equls,ref equals
                //if (item.Doktor.AdSoyad==aranilanKelime)
                //büyük küçük harf
                if (item.Doktor.AdSoyad.ToLower().Contains(aranilanKelime.ToLower()))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = (sayac++).ToString();
                    li.SubItems.Add(item.RandevuTarihi);
                    li.SubItems.Add(item.AdSoyad);
                    li.SubItems.Add(item.Doktor.DoktorunBolumu.BolumunAdi);
                    li.SubItems.Add(item.Doktor.AdSoyad);
                    li.Tag = item;
                    lstHastalar.Items.Add(li);
                }
            }
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
