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


            double porcentagem = Convert.ToDouble(valor.Text) / 100;
            double piss = Convert.ToDouble(pis.Text) * porcentagem;
            double icmss = Convert.ToDouble(icms.Text) * porcentagem;
            double confinss = Convert.ToDouble(confins.Text) * porcentagem;

            double somaImposto = piss + icmss + confinss;
            double porcentagem2 = somaImposto / 100;
            double lucroo = Convert.ToDouble(lucro.Text) * porcentagem2;
            double valorFinal = Convert.ToDouble(valor.Text) + somaImposto + lucroo;

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
