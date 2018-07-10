using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_calculadora
{
    public partial class Form1 : Form
    {
        Double n1, n2, result;

        public Form1()
        {
            InitializeComponent();
        }


        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pontoOuVirgula = RegionInfo.CurrentRegion.IsMetric ? ',' : '.'; ;

            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != pontoOuVirgula)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == pontoOuVirgula) && 
                ((sender as TextBox).Text.IndexOf(pontoOuVirgula) > -1))
            {
                e.Handled = true;
            }
        }

        private void checarEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum2.Focus();
                e.SuppressKeyPress = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void calcularResultado(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                n1 = Double.Parse(txtNum1.Text);
                n2 = Double.Parse(txtNum2.Text);
            }

            string operacao = (sender as Button).Text;

            if (sender.Equals(btnSoma))
                result = n1 + n2;
            if (sender.Equals(btnSubt))
                result = n1 - n2;
            if (sender.Equals(btnMult))
                result = n1 * n2;
            if (sender.Equals(btnDivi))
                result = n1 / n2;

            lblResult.Text = String.Format("{0} {1} {2} = {3}", 
                n1, operacao, n2, result.ToString());
        }
    }
}
