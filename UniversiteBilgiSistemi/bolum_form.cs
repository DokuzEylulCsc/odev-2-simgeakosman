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
    public partial class bolum_form : Form
    {
        public bolum_form()
        {
            InitializeComponent();
        }

        private void btn_bolum_ekle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {

                    Bolum yenibolum = new Bolum();
                    yenibolum.bolum_adi = textBox2.Text;
                    yenibolum.bolum_ID= textBox1.Text;
                    Dictionary<string, string> BolumKaydet = new Dictionary<string, string>();
                    BolumKaydet.Add(textBox1.Text, textBox2.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    foreach (var lsyaz in BolumKaydet)
                    {
                        listBox1.Items.Add(lsyaz);
                    }

                }
                else MessageBox.Show("Eksik Bilgi girdiniz");
            }
            else MessageBox.Show("Eksik Bilgi girdiniz");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genel_form frm = new Genel_form();
            frm.Show();
            this.Hide();

        }

    }
}
