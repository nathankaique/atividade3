using System;

namespace CalculoRendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados do investimento
            double valorPresente = 1000.00;
            double taxaJuros = 0.03; // 3%
            double resgate = 500.00; // Resgate no 5º mês

            // Cabeçalho da tabela
            Console.WriteLine("Tabela de Cálculo do Rendimento com Resgate de R$ 500 no 5º mês");
            Console.WriteLine("\nValor Presente   Taxa de Juros   Mês            Valor Futuro      Valor Resgatado   Saldo Líquido");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            double saldo = valorPresente;

            // Cálculo mês a mês
            for (int mes = 1; mes <= 8; mes++)
            {
                double valorFuturo = saldo * (1 + taxaJuros);
                double valorResgatado = (mes == 5) ? resgate : 0;
                saldo = valorFuturo - valorResgatado;

                // Exibe os dados na tabela
                Console.WriteLine($"R$ {valorPresente:F2}      {taxaJuros * 100:F2} %          {mes}              R$ {valorFuturo:F2}      R$ {valorResgatado:F2}        R$ {saldo:F2}");
                
                // Atualiza o valor presente para o próximo mês
                valorPresente = saldo + valorResgatado;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
    }
}
