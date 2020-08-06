using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisoresApp.Funcoes
{
    public class Divisores
    {
        public List<int> retornaDivisores(int n)
        {
            List<int> divisores = new List<int>();

            // achar divisores
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                        divisores.Add(i);
                    else
                    {
                        divisores.Add(i);
                        divisores.Add(n / i);
                    }
                }
            }
            //for (int i = 1; i <= numero; i++)
            //{
            //    if (numero % i == 0)
            //    {
            //        divisores.Add(i);
            //    }
            //}
            divisores.Sort();
            return divisores;
        }
        public List<int> retornaPrimos(List<int> divisores)
        {
            List<int> divPrimos = new List<int>();
            foreach (var d in divisores)
            {
                if (retornaDivisores(d).Count == 2)
                {
                    divPrimos.Add(d);
                }
            }
            return divPrimos;
        }
    }
}
