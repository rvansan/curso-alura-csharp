using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 : Conversoes e Outros Tipos Numericos");

            double salario;
            salario = 1200.5;

            int salarioEmInterio;
            salarioEmInterio = (int)salario; // estamos fazendo casting da variável do tipo double para o tipo int. 
            Console.WriteLine(salarioEmInterio); // 1200 será o nosso retorno. Note que perdemos precisão no número
            Console.WriteLine("-------------------------------------------");


            // int é um número de 32 bits, ou seja, ele consegue escrever de -2^31 a 2^31 - 1 (-2.147.483.648 a 2.147.483.647)
            int maxInt = 2147483647; // se declararmos "int maxInt = 2147483648" o compilador nos mostra o estouro
            int minInt = -2147483648; // se declararmos "int minInt = -2147483649" o compilador nos mostra o estouro
            Console.WriteLine(minInt);
            Console.WriteLine(maxInt); 
            Console.WriteLine("-------------------------------------------");


            // long é um número de 64 bits, ou seja, ele consegue escrever de -2^63 a 2^63 - 1 (-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807)
            long maxLong = 9223372036854775807; // se declararmos "long maxLong = 9223372036854775808" o compilador nos mostra o estouro
            long minLong = -9223372036854775808; // se declararmos "minLong = -9223372036854775809" o compilador nos mostra o estouro
            Console.WriteLine(maxLong);
            Console.WriteLine(minLong);
            Console.WriteLine("-------------------------------------------");


            // short é um número de 16 bits, ou seja, ele consegue escrever de -2^15 a 2^15 - 1 (-32.768 a 32.767)
            short maxShort = 32767; // se declararmos "short maxShort = 32768" o compilador nos mostra o estouro
            short minShort = -32768; // se declararmos "short minShort = -32769" o compilador nos mostra o estouro
            Console.WriteLine(maxShort);
            Console.WriteLine(minShort);
            Console.WriteLine("-------------------------------------------");


            // byte é um número de 8 bits sem sinal, ou seja, ele consegue escrever de 0 a 2^8 - 1 (0 a 255)
            byte maxByte = 255; // se declararmos "byte maxByte = 256" o compilador nos mostra o estouro
            byte minByte = 0; // se declararmos "byte minByte = -1" o compilador nos mostra o estouro
            Console.WriteLine(maxByte);
            Console.WriteLine(minByte);
            Console.WriteLine("-------------------------------------------");


            // outro tipo de ponto flutuante é o float, menos preciso que o double nas casas decimais. 
            float altura = 1.8f; // para atribuir um valor float precisamos usar o "f" ao final, caso contrário, o VS reclama.
            Console.WriteLine(altura);
            Console.WriteLine("-------------------------------------------");





            Console.ReadLine();
        }
    }
}
