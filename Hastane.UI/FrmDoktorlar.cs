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
    public partial class FrmDoktorlar : Form
    {
        private List<Bolum> bolumler = null;
        public FrmDoktorlar(List<Bolum> bolumler)
        {
            InitializeComponent();
            this.bolumler = bolumler;

            //cmbBolumler.Items.Add(89);
            //cmbBolumler.Items.Add("asdlasdaşsdkl");
        }

        private void FrmDoktorlar_Load(object sender, EventArgs e)
        {
            foreach (Bolum item in this.bolumler)
            {
                cmbBolumler.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidationControl())
            {
                #region MyRegion
                //Doktor d = new Doktor();
                //d.AdSoyad = txtDoktorAd.Text;
                //d.Cep = mstCep.Text;
                //d.Mail = txtMail.Text;
                //d.MezunUni = txtMezuniyet.Text;
                //d.DoktorunBolumu = cmbBolumler.SelectedItem as Bolum;
                //// d.DoktorunBolumu =(Bolum) cmbBolumler.SelectedItem;
                //lstGirilenDoktorlar.Items.Add(d); 
                #endregion

                lstGirilenDoktorlar.Items.Add(new Doktor()
                {
                    AdSoyad = txtDoktorAd.Text,
                    Cep = mstCep.Text,
                    Mail = txtMail.Text,
                    MezunUni = txtMezuniyet.Text,
                    DoktorunBolumu = cmbBolumler.SelectedItem as Bolum

                });

                Temizle();
                //todo doktor ve cep telini yazarak mesaj verdirelim. 
                MessageBox.Show("veri eklenmiştir.");
            }
            else
            {

            }
        }
        /// <summary>
        ///  todo tüm componentleri eski haline donuştur.
        /// </summary>
        private void Temizle()
        {

        }

        private bool ValidationControl()
        {
            return true;
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            //todo kontrolu yap 
            if (true)
            {
                //bolum+doktor
                FrmHastalar frm = new FrmHastalar();
                frm.cmbBolum.DataSource = bolumler;
                //frm.cmbBolum.Items.AddRange(bolumler.ToArray());
               /* frm.cmbDoktor.DataSource*/ frm.tumDoktorlar= DoktorlariBelirle();
                frm.cmbDoktor.Enabled = false;
                frm.Show();
            }
        }

        private List<Doktor> DoktorlariBelirle()
        {
            List<Doktor> doktorListesi = new List<Doktor>();
            foreach (Doktor item in lstGirilenDoktorlar.Items)
            {
                doktorListesi.Add(item);
            }

            return doktorListesi;
        }
    }
}
