using System.Drawing;



public class Cadastro
{
    public double Cadastrar(double valor, double pis, double icms, double confins, double lucro)
    {
        double porcentagem = valor / 100;
        double piss = porcentagem * pis;
        double icmss = porcentagem * icms;
        double confinss = porcentagem * confins;

        double somaImposto = piss + icmss + confinss;
        double porcentagem2 = somaImposto / 100;
        double lucroo = porcentagem2 * lucro;
        double valorFinal = somaImposto + lucroo + valor;

        return valorFinal;
    }
}