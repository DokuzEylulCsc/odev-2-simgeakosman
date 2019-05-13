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
        Fakulte fakulte = new Fakulte();
        private void btn_bolum_ekle_Click(object sender, EventArgs e)
        {
            fakulte.Bolumekle(textBox1.Text, new Bolum(textBox1.Text, textBox2.Text));
            foreach (Bolum bolum in Fakulte.GetBolum.Values)
            {
                listBox1.Items.Add(comboBox1.SelectedItem.ToString()+ bolum.bolum_ID + bolum.bolum_adi);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genel_form frm = new Genel_form();
            frm.Show();
            this.Hide();

        }

        private void bolum_form_Load(object sender, EventArgs e)
        {
            btn_bolum_ekle.Enabled = false;
            foreach (Fakulte fakulte in Universite.GetFakulte.Values)
            {
                comboBox1.Items.Add(fakulte.Fklte_ID + fakulte.Fklteadi);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_bolum_ekle.Enabled = comboBox1.SelectedItem != null;
        }
    }
}
