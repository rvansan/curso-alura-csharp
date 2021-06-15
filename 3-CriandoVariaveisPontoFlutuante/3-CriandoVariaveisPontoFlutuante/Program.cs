using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 : Criando Variáveis Ponto Flutuante");


            //int salario; : não funciona, pois o int não aceita valor com casas decimais
            double salario; // o double já aceita
            salario = 1220.70;
            Console.WriteLine(salario);
            Console.WriteLine("---------------------------------------");



            double idade = 15 / 2; // vamos ter 7 como retorno, pois estamos dividindo 2 números inteiros e devemos ter um inteiro como retorno, ou seja, o número truncado
            int idade1 = 15 / 2; // também funciona e também retorna 7, pelo mesmo motivo anterior
            double idade2 = 15.0 / 2; // agora vamos ter o que esperamos. estamos passando um double para a divisão (15.0). Poderia ter feito 15/0.2, também daria certo
            Console.WriteLine(idade);
            Console.WriteLine(idade1);
            Console.WriteLine(idade2);
            Console.WriteLine("---------------------------------------");







            Console.WriteLine("A execução acabou. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
