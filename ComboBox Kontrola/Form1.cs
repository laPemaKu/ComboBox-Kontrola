using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRezultat.Clear();
            if (cbbOdabir.SelectedIndex == 0)
            {
                txtRezultat.AppendText("1D");
            }
            if (cbbOdabir.SelectedIndex == 1)
            {
                txtRezultat.AppendText("1E");
            }
            if(cbbOdabir.SelectedIndex == 2)
            {
                txtRezultat.AppendText("2D");
            }
            if (cbbOdabir.SelectedIndex == 3)
            {
                txtRezultat.AppendText("3D");
            }
            if (cbbOdabir.SelectedIndex == 4)
            {
                txtRezultat.AppendText("4D");
            }
        }
    }
}
