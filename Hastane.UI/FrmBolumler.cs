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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        //List<string> isimler = new List<string>();
        //List<int> sayilar = new List<int>();

        List<Bolum> bolumler = new List<Bolum>();
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //sayilar.Add(9);
            //int hede= sayilar[0];
            if (!DataBosmu(txtAciklama.Text, txtBolumAdi.Text))
            {
                errorProvider1.SetError(txtBolumAdi, "data alanları boş geçilemez. ");
            }
            else
            {

                errorProvider1.Clear();
                //datayı biriktireyim. 
                Bolum b = new Bolum();
                b.BolumAciklamasi = txtAciklama.Text;
                b.BolumunAdi = txtBolumAdi.Text;
                bolumler.Add(b);

                MessageBox.Show("kayıt başarıldır.");
                FormuTemizle();

                ////obj init
                //bolumler.Add(new Bolum() { 
                //BolumunAdi=txtBolumAdi.Text,
                //BolumAciklamasi=txtAciklama.Text                
                //});
            }
        }

        private void FormuTemizle()
        {
            txtAciklama.Text = txtBolumAdi.Text = string.Empty;
        }

        private bool DataBosmu(string a ,string b)
        {
            //todo yaz
            return true;
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (bolumler.Count == 0)
            {
                MessageBox.Show("data girmeden diğer forma geçiş yapamazsınız.. ");
            }
            else
            {
                FrmDoktorlar frmdoktorlar = new FrmDoktorlar(bolumler);
                frmdoktorlar.Show();
            }
       
        }
    }
}
