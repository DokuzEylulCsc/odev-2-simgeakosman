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
    public partial class ogr_form : Form
    {
        public ogr_form()
        {
            InitializeComponent();
        }

        private void ogr_form_Load(object sender, EventArgs e)
        {
          
            comboBox3.Visible = false;
            label5.Visible = false;
            foreach(Bolum bolum in Fakulte.GetBolum.Values)
            {
                comboBox2.Items.Add(bolum.bolum_adi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genel_form frm = new Genel_form();
            frm.Show();
            this.Hide();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Bolum bolum = new Bolum();
        private void btn_ogr_ekle_Click(object sender, EventArgs e)

        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    bolum.OgrEkle(textBox1.Text, new YuksekLisans(textBox2.Text, textBox1.Text));
                    foreach (Ogrenci ogrenci in Bolum.GetOgrenci.Values)
                    {
                        listBox1.Items.Add(ogrenci.AdiSoyadi + ogrenci.OgrNo);
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    bolum.OgrEkle(textBox1.Text, new Lisans(textBox2.Text, textBox1.Text));
                    foreach (Ogrenci ogrenci in Bolum.GetOgrenci.Values)
                    {
                        listBox1.Items.Add(ogrenci.AdiSoyadi + ogrenci.OgrNo);
                    }

                }
                if (comboBox1.SelectedIndex == 2)
                {
                    bolum.OgrEkle(textBox1.Text, new Doktora(textBox2.Text, textBox1.Text));
                    foreach (Ogrenci ogrenci in Bolum.GetOgrenci.Values)
                    {
                        listBox1.Items.Add(ogrenci.AdiSoyadi + ogrenci.OgrNo);
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Zaten bu öğrenciyi eklemiştiniz.");
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            label5.Visible = true;
            foreach (Ders ders in Bolum.GetDers.Values)
            {
                comboBox3.Items.Add(ders.ders_adi);
            }
        }
    }
}
