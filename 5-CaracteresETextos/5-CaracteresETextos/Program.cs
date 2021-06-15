using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 : Caracteres e Textos");

            // char é um tipo de 16 bits, usado para guardar caracteres  
            char primeiraLetra = 'a'; // usamos aspas simples para inserir um caracter. Aspas duplas são usadas para definir um texto
            Console.WriteLine(primeiraLetra);
            Console.WriteLine("---------------------------------------");

            // internamente, um char é armazenado como um número. Podemos salvar diretamente um número dentro de um char atrás de um cast
            // char utiliza a tabela ASCII para converter esses números em caracteres
            char numero = (char)65; // vamos ter "A" como retorno e não o número 65. 
            Console.WriteLine(numero);
            numero = (char)(numero + 1); // podemos somar os valores e depois fazer um cast, pois essa soma resulta em um int
            Console.WriteLine(numero);
            Console.WriteLine("---------------------------------------");

            // string é o tipo usado para representação de textos
            string titulo = "rafael" 
                + " " 
                + "vansan";
            Console.WriteLine(titulo);
            Console.WriteLine("---------------------------------------");

            // podemos utilizar uma @ na frente da string para que ele interprete tudo, inclusive saltos e espaços dentro da string
            string tituloLiteral = @"rafael


    vansan";

            Console.WriteLine(tituloLiteral);
            Console.WriteLine("---------------------------------------");








            Console.ReadLine();

        }
    }
}
