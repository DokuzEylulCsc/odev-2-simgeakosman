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
    }
}
