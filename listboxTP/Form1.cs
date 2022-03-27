using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void txtSaisie_TextChanged(object sender, EventArgs e)
        {
            if (txtSaisie.Text != "") btnAjouter.Enabled = true;
            else btnAjouter.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(txtSaisie.Text.Trim());
            txtSaisie.Clear();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst1.SelectedIndex != -1)
            {
                btn1to2.Enabled = true;
                btnEffacer1.Enabled = true;
            }
            else
            {
                btnEffacer1.Enabled = false;
                btn1to2.Enabled = false;
            }
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst2.SelectedIndex != -1)
            {
                btn2to1.Enabled = true;
                btnEffacer2.Enabled = true;
            }
            else
            {
                btnEffacer2.Enabled = false;
                btn2to1.Enabled = false;
            }
        }

        private void btnEffacer1_Click(object sender, EventArgs e)
        {

            lst1.Items.RemoveAt(lst1.SelectedIndex);
           
        }

        private void btnEffacer2_Click(object sender, EventArgs e)
        {

            lst2.Items.RemoveAt(lst2.SelectedIndex);
        }

        private void btn1to2_Click(object sender, EventArgs e)
        {
            lst2.Items.Add(lst1.SelectedItem);
            lst1.Items.RemoveAt(lst1.SelectedIndex);
            
        }

        private void btn2to1_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(lst2.SelectedItem);
            lst2.Items.RemoveAt(lst2.SelectedIndex);
        }

        private void FrmList_Load(object sender, EventArgs e)
        {

        }
    }
}
