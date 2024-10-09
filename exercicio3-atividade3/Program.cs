using System;

namespace CalculoRendimento
{
    class Investimento
    {
        public double ValorInvestido { get; set; }
        public double TaxaJuros { get; set; }
        public double Resgate { get; set; }
        public int Periodo { get; set; }

        public void CalcularEExibirTabela()
        {
            double saldo = ValorInvestido;

            Console.WriteLine("\nTabela de Cálculo do Rendimento com Resgate");
            Console.WriteLine("\nValor Investido   Taxa de Juros   Mês      Valor Futuro    Valor Resgatado   Saldo Líquido");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            for (int mes = 1; mes <= Periodo; mes++)
            {
                // Calcula o valor futuro após aplicar a taxa de juros
                double valorFuturo = saldo * (1 + TaxaJuros / 100);
                
                // Se for o 5º mês, subtrai o valor do resgate
                double valorResgatado = (mes == 5) ? Resgate : 0; 
                saldo = valorFuturo - valorResgatado; // Atualiza o saldo após o resgate

                // Exibe os dados na tabela
                Console.WriteLine($"R$ {ValorInvestido:F2}      {TaxaJuros:F2} %         {mes}      R$ {valorFuturo:F2}      R$ {valorResgatado:F2}        R$ {saldo:F2}");

                // Atualiza o valor investido para o próximo mês
                ValorInvestido = saldo; // O saldo atualizado será o novo valor investido
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Investimento investimento = new Investimento();

            // Leitura de entradas
            Console.Write("Informe o valor investido: R$ ");
            investimento.ValorInvestido = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a taxa de juros (em %): ");
            investimento.TaxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o período (em meses): ");
            investimento.Periodo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor do resgate (no 5º mês): R$ ");
            investimento.Resgate = Convert.ToDouble(Console.ReadLine());

            // Cálculo e exibição da tabela
            investimento.CalcularEExibirTabela();

            Console.ReadKey();
        }
    }
}
