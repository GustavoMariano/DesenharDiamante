using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenharDiamante
{
    public class Diamante : LetrasDiamante
    {
        public string[] diamantePronto;
        private string[] cadeiaComEspaco;
        public Diamante(string letra)
        {
            char letraDiamante = Convert.ToChar(letra.ToUpper());
            this.diamantePronto = ConstruirDiamante(letraDiamante);
        }

        public string[] ConstruirDiamante(char letra)
        {
            string[] linha = new String[alfabeto.Count];
            foreach (char letraAlfabeto in alfabeto.Keys)
            {
                if (letra.Equals(letraAlfabeto))
                {
                    int qtdEsapaco = alfabeto[letraAlfabeto];
                    linha = GerarEspacos(qtdEsapaco + 1, Convert.ToString(letra));
                }
            }

            return linha;
        }

        private string[] GerarEspacos(int qtdEsapaco, string letra)
        {
            diamantePronto = new string[qtdEsapaco * 2];
            cadeiaComEspaco = new String[qtdEsapaco];
            int cont = GerarEspacosExternosSuperiores(qtdEsapaco, cadeiaComEspaco);
            cadeiaComEspaco = GerarLetrasDaEsquerda(qtdEsapaco, cadeiaComEspaco);
            cont = GerarEspacosInternosSuperiores(qtdEsapaco, cadeiaComEspaco);
            cadeiaComEspaco = GerarLetrasDaDireita(qtdEsapaco, cadeiaComEspaco);
            diamantePronto = GerarStringOposta(cadeiaComEspaco, letra);

            return diamantePronto;
        }

        private string[] GerarStringOposta(string[] cadeiaComEspaco, string letra)
        {
            string[] cadeia = new string[cadeiaComEspaco.Length * 2];
            for (int i = 0; i < cadeiaComEspaco.Length * 2; i++)
            {
                if (i < cadeiaComEspaco.Length)
                    cadeia[i] = cadeiaComEspaco[i];

                else
                {
                    for (int j = cadeiaComEspaco.Length - 1; j >= 0; j--)
                    {
                        if (j != cadeiaComEspaco.Length - 1)
                            cadeia[i] = cadeiaComEspaco[j];
                    }
                    return cadeia;
                    break;
                }
                return cadeia;
            }
            return cadeia;
        }

        private string[] GerarLetrasDaDireita(int qtdEsapaco, string[] cadeiaComEspaco)
        {
            foreach (char item in alfabeto.Keys)
            {
                if (alfabeto[item] == 0)
                    cadeiaComEspaco[alfabeto[item]] += "";
                else if (alfabeto[item] < qtdEsapaco)
                    cadeiaComEspaco[alfabeto[item]] += Convert.ToString(item);
                else
                    break;
            }
            return cadeiaComEspaco;
        }

        private static int GerarEspacosInternosSuperiores(int qtdEsapaco, string[] cadeiaComEspaco)
        {
            int cont = qtdEsapaco - 1;
            for (int i = 0; i < qtdEsapaco; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    cadeiaComEspaco[i] += " ";
                    if (j >= 1)
                        cadeiaComEspaco[i] += " ";
                }
            }

            return cont;
        }

        private static string[] GerarLetrasDaEsquerda(int qtdEsapaco, string[] cadeiaComEspaco)
        {
            foreach (char item in alfabeto.Keys)
            {
                if (alfabeto[item] < qtdEsapaco)
                    cadeiaComEspaco[alfabeto[item]] += Convert.ToString(item);
                else
                    break;
            }
            return cadeiaComEspaco;
        }

        private static int GerarEspacosExternosSuperiores(int qtdEsapaco, string[] cadeiaComEspaco)
        {
            int cont = qtdEsapaco - 1;

            for (int i = 0; i < qtdEsapaco; i++)
            {
                for (int j = 0; j < cont; j++)
                {
                    cadeiaComEspaco[i] += " ";
                }
                cont--;
            }

            return cont;
        }
    }
}
