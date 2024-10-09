using System;

namespace RendimentoFuturo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valoresInvestidos = { 1000, 5500, 12000 };
            double[] taxasJuros = { 3.0, 2.48, 2.0 };
            double periodoTotal = 8 + (10.0 / 30.0); // 8 meses e 10 dias convertidos para meses
            periodoTotal = Math.Round(periodoTotal, 1); // Arredondando para 1 casa decimal, resultando em 8,3

            Console.WriteLine("Tabela de Cálculo do Rendimento Futuro para 8 meses e 10 dias\n");
            Console.WriteLine("{0,-15} {1,-15} {2,-20} {3,-15}", "Valor Presente", "Taxa de Juros", "Período (Meses)", "Valor Futuro");

            for (int i = 0; i < valoresInvestidos.Length; i++)
            {
                double valorFuturo = valoresInvestidos[i] * Math.Pow((1 + (taxasJuros[i] / 100)), periodoTotal);
                Console.WriteLine("{0,-15:C} {1,-15:P2} {2,-20:F1} {3,-15:C}", 
                    valoresInvestidos[i], 
                    taxasJuros[i] / 100, 
                    periodoTotal, 
                    valorFuturo);
            }

            Console.ReadKey();
        }
    }
}
