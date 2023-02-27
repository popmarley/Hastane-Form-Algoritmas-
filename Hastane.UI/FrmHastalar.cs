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
    public partial class FrmHastalar : Form
    {
        //todo hoca
        public List<Doktor> tumDoktorlar= new List<Doktor>();
        public FrmHastalar()
        {
            InitializeComponent();
        }

        private void FrmHastalar_Load(object sender, EventArgs e)
        {

        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Enabled = true;
            Bolum secilenBolum = cmbBolum.SelectedItem as Bolum;

            foreach (Doktor doktor in tumDoktorlar)
            {
                if (secilenBolum.BolumunAdi == doktor.DoktorunBolumu.BolumunAdi)
                {
                    cmbDoktor.Items.Add(doktor);
                }
            }
            //todo seçilen bolumun hiç doktoru yok ise ????
        }
        List<Hasta> hastalarimiz = new List<Hasta>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //validation
            hastalarimiz.Add(new Hasta()
            {
                AdSoyad = txtADSoyad.Text,
                RandevuTarihi = DateTime.Now.ToShortDateString(),
                Doktor = cmbDoktor.SelectedItem as Doktor,
                //Doktor = (Doktor)cmbDoktor.SelectedItem
            });
            MessageBox.Show("hasta bilgileri başarıyla kaydedilmiştir. ");
            #region MyRegion
            //int? i = 0;
            //i = null; 
            #endregion
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            FrmGunSonu frm = new FrmGunSonu(hastalarimiz,BolumleriGonder(),tumDoktorlar);
            frm.Show();
        }

        public List<Bolum> BolumleriGonder()
        {
            return null;
        }
    }
}
