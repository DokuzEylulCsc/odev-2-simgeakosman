﻿using System;
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
            Fakulte deger = new Fakulte();
            deger.Fklteadi = textBox2.Text;
            deger.Fklte_ID = textBox1.Text;
            deger.save("Fakulte.xml");
        }
    }
}
