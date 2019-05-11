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
    public partial class fakulte_form : Form
    {
        public fakulte_form()
        {
            InitializeComponent();
        }

        private void fakulte_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genel_form frm = new Genel_form();
            frm.Show();
            this.Hide();
        }

        private void btn_fakulte_ekle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {

                    Fakulte deger = new Fakulte();
                    deger.Fklteadi = textBox2.Text;
                    deger.Fklte_ID = textBox1.Text;
                    Dictionary<string, string> FakulteKaydet = new Dictionary<string, string>();
                    FakulteKaydet.Add(textBox1.Text, textBox2.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    foreach (var grdyaz in FakulteKaydet)
                    {
                        listBox1.Items.Add(grdyaz);
                    }

                }
                else Console.WriteLine("Eksik Bilgi girdiniz");
            }
            else Console.WriteLine("Eksik Bilgi girdiniz");

            
        }
    }
}
