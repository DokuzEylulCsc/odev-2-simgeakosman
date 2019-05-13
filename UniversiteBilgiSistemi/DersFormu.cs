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
    public partial class ders_form : Form
    {
        public ders_form()
        {
            InitializeComponent();
        }

        private void ders_form_Load(object sender, EventArgs e)
        {
            btn_ders_ekle.Enabled = false;
            foreach (OgretimElemani hoca in Bolum.GetHoca.Values)
            {
                comboBox1.Items.Add(hoca.Hoca_ID + hoca.Hoca_Adi_Soyadi);
            }
           
            foreach (Bolum bolum in Fakulte.GetBolum.Values)
            {
                comboBox2.Items.Add(bolum.bolum_ID +"  "+ bolum.bolum_adi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genel_form frm = new Genel_form();
            frm.Show();
            this.Hide();
        }
        Bolum bolum = new Bolum();

        private void btn_ders_ekle_Click(object sender, EventArgs e)
        {
            bolum.Dersekle(textBox1.Text, new Ders(textBox2.Text, textBox1.Text));
            foreach (Ders ders in Bolum.GetDers.Values)
            {
                listBox1.Items.Add(ders.ders_ID + ders.ders_adi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ders_ekle.Enabled = (comboBox1.SelectedItem != null&& comboBox2.SelectedItem != null);
        }
    }
}
