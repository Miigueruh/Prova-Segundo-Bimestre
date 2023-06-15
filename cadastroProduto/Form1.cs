using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lorem.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double porcentagem = valor / 100;
            double piss = porcentagem * pis;
            double icmss = porcentagem * icms;
            double confinss = porcentagem * confins;

            double somaImposto = piss + icmss + confinss;
            double porcentagem2 = somaImposto / 100;
            double lucroo = porcentagem2 * lucro;
            double valorFinal = somaImposto + lucroo + valor);

            lorem.Text = $"Valor de compra: {valorFinal}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo.Text = "";
            unidade.Text = "";
            descricao.Text = "";
            valor.Text = "";
            pis.Text = "";
            icms.Text = "";
            confins.Text = "";
            lucro.Text = "";
            lorem.Text = "";
        }
    }
}
