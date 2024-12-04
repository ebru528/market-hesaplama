using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = textBoxTC.Text;
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string cinsiyet = radioButtonKadin.Checked ? "Kadın" : radioButtonErkek.Checked ? "Erkek" : "Belirtilmemiş";
            string egitimDurumu = radioButtonLise.Checked ? "Lise" : radioButtonOnLisans.Checked ? "Ön Lisans" : radioButtonLisans.Checked ? "Lisans" : "Yüksek Lisans";

            string uygulamalar = string.Join(", ", checkedListBoxUygulamalar.CheckedItems);
            string programlamaDilleri = string.Join(", ", checkedListBoxProgramlamaDilleri.CheckedItems);
            string hedef = listBoxHedefiniz.SelectedItem?.ToString() ?? "Belirtilmemiş";

            MessageBox.Show($"TC: {tc}\nAd: {ad}\nSoyad: {soyad}\nCinsiyet: {cinsiyet}\nEğitim Durumu: {egitimDurumu}\nUygulamalar: {uygulamalar}\nProgramlama Dilleri: {programlamaDilleri}\nHedefiniz: {hedef}", "Bilgiler Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTC.Clear();
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            radioButtonKadin.Checked = false;
            radioButtonErkek.Checked = false;
            radioButtonBelirtilmemis.Checked = false;
            radioButtonLise.Checked = false;
            radioButtonOnLisans.Checked = false;
            radioButtonLisans.Checked = false;
            radioButtonYuksekLisans.Checked = false;
            foreach (int i in checkedListBoxUygulamalar.CheckedIndices)
            {
                checkedListBoxUygulamalar.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in checkedListBoxProgramlamaDilleri.CheckedIndices)
            {
                checkedListBoxProgramlamaDilleri.SetItemCheckState(i, CheckState.Unchecked);
            }
            listBoxHedefiniz.ClearSelected();
        }
    }
}
        

