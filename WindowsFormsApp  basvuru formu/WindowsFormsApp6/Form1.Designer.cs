namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButtonBelirtilmemis = new System.Windows.Forms.RadioButton();
            this.radioButtonLise = new System.Windows.Forms.RadioButton();
            this.radioButtonOnLisans = new System.Windows.Forms.RadioButton();
            this.radioButtonLisans = new System.Windows.Forms.RadioButton();
            this.radioButtonYuksekLisans = new System.Windows.Forms.RadioButton();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.checkedListBoxUygulamalar = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxProgramlamaDilleri = new System.Windows.Forms.CheckedListBox();
            this.listBoxHedefiniz = new System.Windows.Forms.ListBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.labelEgitimDurumu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(110, 20);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTC.TabIndex = 0;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(110, 50);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(110, 80);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(110, 110);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(52, 17);
            this.radioButtonKadin.TabIndex = 3;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(110, 130);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
            this.radioButtonErkek.TabIndex = 4;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // radioButtonBelirtilmemis
            // 
            this.radioButtonBelirtilmemis.AutoSize = true;
            this.radioButtonBelirtilmemis.Location = new System.Drawing.Point(110, 150);
            this.radioButtonBelirtilmemis.Name = "radioButtonBelirtilmemis";
            this.radioButtonBelirtilmemis.Size = new System.Drawing.Size(81, 17);
            this.radioButtonBelirtilmemis.TabIndex = 5;
            this.radioButtonBelirtilmemis.TabStop = true;
            this.radioButtonBelirtilmemis.Text = "Belirtilmemiş";
            this.radioButtonBelirtilmemis.UseVisualStyleBackColor = true;
            // 
            // radioButtonLise
            // 
            this.radioButtonLise.AutoSize = true;
            this.radioButtonLise.Location = new System.Drawing.Point(289, 107);
            this.radioButtonLise.Name = "radioButtonLise";
            this.radioButtonLise.Size = new System.Drawing.Size(44, 17);
            this.radioButtonLise.TabIndex = 6;
            this.radioButtonLise.TabStop = true;
            this.radioButtonLise.Text = "Lise";
            this.radioButtonLise.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnLisans
            // 
            this.radioButtonOnLisans.AutoSize = true;
            this.radioButtonOnLisans.Location = new System.Drawing.Point(289, 127);
            this.radioButtonOnLisans.Name = "radioButtonOnLisans";
            this.radioButtonOnLisans.Size = new System.Drawing.Size(72, 17);
            this.radioButtonOnLisans.TabIndex = 7;
            this.radioButtonOnLisans.TabStop = true;
            this.radioButtonOnLisans.Text = "Ön Lisans";
            this.radioButtonOnLisans.UseVisualStyleBackColor = true;
            // 
            // radioButtonLisans
            // 
            this.radioButtonLisans.AutoSize = true;
            this.radioButtonLisans.Location = new System.Drawing.Point(289, 147);
            this.radioButtonLisans.Name = "radioButtonLisans";
            this.radioButtonLisans.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLisans.TabIndex = 8;
            this.radioButtonLisans.TabStop = true;
            this.radioButtonLisans.Text = "Lisans";
            this.radioButtonLisans.UseVisualStyleBackColor = true;
            // 
            // radioButtonYuksekLisans
            // 
            this.radioButtonYuksekLisans.AutoSize = true;
            this.radioButtonYuksekLisans.Location = new System.Drawing.Point(289, 167);
            this.radioButtonYuksekLisans.Name = "radioButtonYuksekLisans";
            this.radioButtonYuksekLisans.Size = new System.Drawing.Size(94, 17);
            this.radioButtonYuksekLisans.TabIndex = 9;
            this.radioButtonYuksekLisans.TabStop = true;
            this.radioButtonYuksekLisans.Text = "Yüksek Lisans";
            this.radioButtonYuksekLisans.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(220, 20);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 10;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(220, 50);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 11;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBoxUygulamalar
            // 
            this.checkedListBoxUygulamalar.FormattingEnabled = true;
            this.checkedListBoxUygulamalar.Items.AddRange(new object[] {
            "Uygulama 1",
            "Uygulama 2",
            "Uygulama 3"});
            this.checkedListBoxUygulamalar.Location = new System.Drawing.Point(16, 214);
            this.checkedListBoxUygulamalar.Name = "checkedListBoxUygulamalar";
            this.checkedListBoxUygulamalar.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxUygulamalar.TabIndex = 12;
            // 
            // checkedListBoxProgramlamaDilleri
            // 
            this.checkedListBoxProgramlamaDilleri.FormattingEnabled = true;
            this.checkedListBoxProgramlamaDilleri.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Python"});
            this.checkedListBoxProgramlamaDilleri.Location = new System.Drawing.Point(150, 213);
            this.checkedListBoxProgramlamaDilleri.Name = "checkedListBoxProgramlamaDilleri";
            this.checkedListBoxProgramlamaDilleri.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxProgramlamaDilleri.TabIndex = 13;
            // 
            // listBoxHedefiniz
            // 
            this.listBoxHedefiniz.FormattingEnabled = true;
            this.listBoxHedefiniz.Items.AddRange(new object[] {
            "Hedef 1",
            "Hedef 2",
            "Hedef 3"});
            this.listBoxHedefiniz.Location = new System.Drawing.Point(289, 213);
            this.listBoxHedefiniz.Name = "listBoxHedefiniz";
            this.listBoxHedefiniz.Size = new System.Drawing.Size(120, 95);
            this.listBoxHedefiniz.TabIndex = 14;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(13, 23);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(24, 13);
            this.labelTC.TabIndex = 15;
            this.labelTC.Text = "TC:";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(13, 53);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(23, 13);
            this.labelAd.TabIndex = 16;
            this.labelAd.Text = "Ad:";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(13, 83);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(40, 13);
            this.labelSoyad.TabIndex = 17;
            this.labelSoyad.Text = "Soyad:";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Location = new System.Drawing.Point(13, 113);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(46, 13);
            this.labelCinsiyet.TabIndex = 18;
            this.labelCinsiyet.Text = "Cinsiyet:";
            // 
            // labelEgitimDurumu
            // 
            this.labelEgitimDurumu.AutoSize = true;
            this.labelEgitimDurumu.Location = new System.Drawing.Point(192, 110);
            this.labelEgitimDurumu.Name = "labelEgitimDurumu";
            this.labelEgitimDurumu.Size = new System.Drawing.Size(78, 13);
            this.labelEgitimDurumu.TabIndex = 19;
            this.labelEgitimDurumu.Text = "Eğitim Durumu:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.labelEgitimDurumu);
            this.Controls.Add(this.labelCinsiyet);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.listBoxHedefiniz);
            this.Controls.Add(this.checkedListBoxProgramlamaDilleri);
            this.Controls.Add(this.checkedListBoxUygulamalar);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.radioButtonYuksekLisans);
            this.Controls.Add(this.radioButtonLisans);
            this.Controls.Add(this.radioButtonOnLisans);
            this.Controls.Add(this.radioButtonLise);
            this.Controls.Add(this.radioButtonBelirtilmemis);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.radioButtonKadin);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxTC);
            this.Name = "Form1";
            this.Text = "İş Başvuru Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.RadioButton radioButtonBelirtilmemis;
        private System.Windows.Forms.RadioButton radioButtonLise;
        private System.Windows.Forms.RadioButton radioButtonOnLisans;
        private System.Windows.Forms.RadioButton radioButtonLisans;
        private System.Windows.Forms.RadioButton radioButtonYuksekLisans;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.CheckedListBox checkedListBoxUygulamalar;
        private System.Windows.Forms.CheckedListBox checkedListBoxProgramlamaDilleri;
        private System.Windows.Forms.ListBox listBoxHedefiniz;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.Label labelEgitimDurumu;
    }
}
