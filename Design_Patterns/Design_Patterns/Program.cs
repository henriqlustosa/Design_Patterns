using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
           double valor = 250.60;
            Orcamento orcamento = new Orcamento(valor);

            CalculadorDeImpostos calculadora = new CalculadorDeImpostos();

            calculadora.RealizaCalculo(orcamento, "ISS");
        }
    }
}
