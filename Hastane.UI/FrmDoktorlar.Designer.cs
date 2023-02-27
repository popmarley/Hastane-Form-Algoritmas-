
namespace Hastane.UI
{
    partial class FrmDoktorlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.txtMezuniyet = new System.Windows.Forms.TextBox();
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.mstCep = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.lstGirilenDoktorlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor  Tanımlama Ekranı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mezuniyet Üni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cep Tel :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mail : ";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(270, 126);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(430, 30);
            this.txtDoktorAd.TabIndex = 1;
            // 
            // txtMezuniyet
            // 
            this.txtMezuniyet.Location = new System.Drawing.Point(270, 181);
            this.txtMezuniyet.Name = "txtMezuniyet";
            this.txtMezuniyet.Size = new System.Drawing.Size(430, 30);
            this.txtMezuniyet.TabIndex = 1;
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(270, 231);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(430, 33);
            this.cmbBolumler.TabIndex = 2;
            // 
            // mstCep
            // 
            this.mstCep.Location = new System.Drawing.Point(270, 286);
            this.mstCep.Mask = "(999) 000-0000";
            this.mstCep.Name = "mstCep";
            this.mstCep.Size = new System.Drawing.Size(430, 30);
            this.mstCep.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(270, 342);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(430, 30);
            this.txtMail.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(521, 378);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(179, 61);
            this.btnGec.TabIndex = 4;
            this.btnGec.Text = ">>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // lstGirilenDoktorlar
            // 
            this.lstGirilenDoktorlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstGirilenDoktorlar.FormattingEnabled = true;
            this.lstGirilenDoktorlar.ItemHeight = 25;
            this.lstGirilenDoktorlar.Location = new System.Drawing.Point(725, 0);
            this.lstGirilenDoktorlar.Name = "lstGirilenDoktorlar";
            this.lstGirilenDoktorlar.Size = new System.Drawing.Size(551, 490);
            this.lstGirilenDoktorlar.TabIndex = 5;
            // 
            // FrmDoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 490);
            this.Controls.Add(this.lstGirilenDoktorlar);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mstCep);
            this.Controls.Add(this.cmbBolumler);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtMezuniyet);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoktorlar";
            this.Text = "FrmDoktorlar";
            this.Load += new System.EventHandler(this.FrmDoktorlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.TextBox txtMezuniyet;
        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.MaskedTextBox mstCep;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.ListBox lstGirilenDoktorlar;
    }
}