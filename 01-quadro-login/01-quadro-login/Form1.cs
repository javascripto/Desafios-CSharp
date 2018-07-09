using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_quadro_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEnter.Enabled = false;
        }

        private void textChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = txtUser.Text != "" && txtPass.Text != "";
        }

        private void checkEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender.Equals(txtUser))
                    txtPass.Focus();
                else if (btnEnter.Enabled)
                    btnEnter_Click(this, EventArgs.Empty);

                // As seguintes instruções servem para evitar o bipe 
                // do sistema ao pressionar enter na textbox txtUser
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou!");
        }

    }
}
