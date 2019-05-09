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
    public partial class Genel_form : Form
    {
        public Genel_form()
        {
            InitializeComponent();
        }

        private void btn_fakulte_Click(object sender, EventArgs e)
        {
            fakulte_form frm = new fakulte_form();
            frm.Show();
            this.Hide();

        }

        private void btn_ogr_Click(object sender, EventArgs e)
        {
           ogr_form frm = new ogr_form();
            frm.Show();
            this.Hide();
        }

        private void btn_ders_Click(object sender, EventArgs e)
        {
            ders_form frm = new ders_form();
            frm.Show();
            this.Hide();
        }

        private void btn_hoca_Click(object sender, EventArgs e)
        {
            hoca_form frm = new hoca_form();
            frm.Show();
            this.Hide();
        }

        private void btn_listeleme_Click(object sender, EventArgs e)
        {
            Listeleme frm = new Listeleme();
            frm.Show();
            this.Hide();
        }
    }
}
