using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");


            Console.WriteLine("-------------- Laço WHILE------------------");
            double valorInvestido = 1000;
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                contadorMes++;
            }
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("-------------- Laço FOR------------------");
            double valorInvestido2 = 1000;
            for (int contadorMes2=1; contadorMes2<=12; contadorMes2++ )
            {
                valorInvestido2 += valorInvestido2 * 0.0036;
                Console.WriteLine("Após " + contadorMes2 + " meses, você terá R$" + valorInvestido2);
            }
            Console.WriteLine("--------------------------------------------");



            Console.WriteLine("-------------- Laço FOR CONCATENADO ------------------");
            double valorInvestido3 = 1000;
            double fatorRendimento = 1.0036;
            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes3 = 1; contadorMes3 <= 12; contadorMes3++)
                {
                    valorInvestido3 *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento você terá R$ " + valorInvestido3);
            Console.WriteLine("--------------------------------------------");



            Console.WriteLine("-------------- Laço FOR ------------------");
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");




            Console.ReadLine();
        }
    }
}
