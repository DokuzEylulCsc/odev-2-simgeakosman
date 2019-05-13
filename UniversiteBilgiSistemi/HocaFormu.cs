using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteBilgiSistemi
{
    public partial class hoca_form : Form
    {
        public hoca_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genel_form frm = new Genel_form();
            frm.Show();
            this.Hide();
        }
        Bolum bolum = new Bolum();
        private void btn_hoca_ekle_Click(object sender, EventArgs e)
        {
            bolum.HocaEkle(textBox1.Text, new OgretimElemani(textBox2.Text, textBox1.Text));
            foreach (OgretimElemani hoca in Bolum.GetHoca.Values)
            {
                listBox1.Items.Add(hoca.Hoca_ID + hoca.Hoca_Adi_Soyadi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_hoca_ekle.Enabled = comboBox1.SelectedItem != null;
        }

        private void hoca_form_Load(object sender, EventArgs e)
        {
            btn_hoca_ekle.Enabled = false;
            foreach (Bolum bolum in Fakulte.GetBolum.Values)
            {
                comboBox1.Items.Add(bolum.bolum_ID +" "+ bolum.bolum_adi);
            }
        }
    }
}
