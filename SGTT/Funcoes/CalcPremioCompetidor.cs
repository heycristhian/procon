using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCRP.Funcoes
{
    public class CalcPremioCompetidor
    {
        static public float[] calcPorcentagem()
        {
            float[] perc = { 35f, 20f, 15f, 10f, 7.5f, 2.5f, 2.5f, 2.5f, 2.5f, 2.5f };
            return perc;
        }

        static public float[] calcPorcentagem(float[] valores, float valor)
        {
            for(int i = 0; i < 10; i++)
            {
                valores[i] = valores[i] * 100 / valor;
            }
            return valores;
        }

        static public float[] calcularValores(float valor, float[] perc)
        {
            float[] valores = new float[10];
            for (int i = 0; i < 10; i++)
            {
                valores[i] = valor * perc[i] / 100;
            }
            return valores;
        }
    }
}
