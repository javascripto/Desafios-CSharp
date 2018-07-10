using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_lista_compras
{
    public partial class Form1 : Form
    {
        class Produto
        {
            public string nome;
            public double preco;

            public Produto(string n, double p)
            {
                this.nome = n;
                this.preco = p;
            }
            public Produto() { }
        }

        List<Produto> listaProdutos;
        List<Produto> listaCompras = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaProdutos = new List<Produto>()
            {
                new Produto("Laranja", 10),
                new Produto("Abacaxi", 25),
                new Produto(){ nome = "Banana", preco = 5.5 } // Forma alternativa sem construtor
            };

            foreach (Produto produto in listaProdutos )
            {
                lstProdutos.Items.Add(construirItem(produto));
            }
        }

        private string construirItem(Produto produto)
        {
            string preco = produto.preco.ToString("0.00") + " $";
            return produto.nome 
                + new string(' ', 23 - produto.nome.Length - preco.Length) 
                + preco;
        }

        private void adicionarNaLista(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedItems.Count > 0)
            {
                int index = (sender as ListBox).SelectedIndex;
                lstCompras.Items.Add(construirItem(listaProdutos.ElementAt(index)));
                listaCompras.Add(listaProdutos.ElementAt(index));
                calcularTotal();
            }
               
        }

        private void limparListaCompras(object sender, EventArgs e)
        {
            lstCompras.Items.Clear();
            listaCompras.Clear();
            lblTotal.Text = "0 $";
        }

        private void finalizarCompra(object sender, EventArgs e)
        {
            MessageBox.Show("Compra Finalizada!\nTotal: " + lblTotal.Text);
            limparListaCompras(sender, EventArgs.Empty);
        }
        
        private void calcularTotal()
        {
            double preco = 0;

            foreach (Produto p in listaCompras)
                preco += p.preco;

            lblTotal.Text = preco + " $";
        }

        private void removerItem(object sender, EventArgs e)
        {
            if ((lstCompras as ListBox).SelectedItems.Count > 0)
            {
                int index = (sender as ListBox).SelectedIndex;
                listaCompras.RemoveAt(index);
                (lstCompras as ListBox).Items.RemoveAt(index);
                calcularTotal();
            }
        }
    }
}
