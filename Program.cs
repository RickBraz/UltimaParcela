using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibe a data da última parcela e o valor das parcelas.");
            Console.Write("Digite o numero do financeamento:");
            string financeamento = Console.ReadLine();
            decimal x = Convert.ToDecimal(financeamento);

            Console.Write("Digite o numero de parcelas mensais (SemJuros): ");
            string parcelas = Console.ReadLine();
            decimal y = Convert.ToDecimal(parcelas);
            decimal Divisao = x / y;
            int z = Convert.ToInt32(y);
            DateTime FinalDaParcela = DateTime.Today.AddMonths(z);
            Console.WriteLine($"Sua ultima parcela será em {FinalDaParcela}, no valor de {Divisao}. ");



        }
    }
}
