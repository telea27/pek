using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void listbox_pekaruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_hozzaadas_1_Click(object sender, EventArgs e)
        {
            Pekaru pekaru = new Pekaru(txtbox__nev.Text, Convert.ToInt32(txtbox_ar.Text), chckbox_laktozmentes.Checked ? true : false);
            listbox_pekaruk.Items.Add(pekaru);
            
        }

        private void btn_hozzaadas_2_Click(object sender, EventArgs e)
        {
            Pekseg pekseg = new Pekseg(txtbox_pekseg.Text);
            listbox_peksegek.Items.Add(pekseg);
        }

        private void btn_plusz_Click(object sender, EventArgs e)
        {
            if (listbox_pekaruk.SelectedItem != null && listbox_peksegek.SelectedItem != null)
            {
                listbox_pekaru_2.Items.Add(listbox_pekaruk.SelectedItem);
            }
        }
    }
}
