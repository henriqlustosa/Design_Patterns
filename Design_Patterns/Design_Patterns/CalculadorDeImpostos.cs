using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, String imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.1;
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.06;
                Console.WriteLine(iss);
            }
            Console.ReadKey();
        }

    }
}
