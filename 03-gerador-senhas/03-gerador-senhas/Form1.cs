using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_gerador_senhas
{
    public partial class Form1 : Form
    {
        int num_senhas = 20;
        string selecionado = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";

            if (checkUpper.Checked)
                chars += chars.ToUpper();
            if (checkNum.Checked)
                chars += "0123456789";
            if (checkSym.Checked)
                chars += "#/$!?=-\"@*-=_+";

            lstPass.Items.Clear();

            Random r = new Random();

            for (int n = 1; n < num_senhas; n++)
            {
                StringBuilder str = new StringBuilder();

                for ( int x = 1; x <= numChars.Value; x++)
                {
                    int pos = r.Next(0, chars.Length);
                    str.Append(chars[pos]);
                }
                lstPass.Items.Add(str);
            }
            btnCopy.Visible = false;
        }

        private void lstPass_SelectedValueChanged(object sender, EventArgs e)
        {
            selecionado = (sender as ListBox).SelectedItem.ToString();
            btnCopy.Visible = true;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(selecionado);
            MessageBox.Show(selecionado + " Copiado!");
        }
    }
}
