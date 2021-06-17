﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IRPF");


            // De 1900.0 até 2800.0, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142;
            // De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
            // De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7.5%");
                Console.WriteLine("Você pode deduzir até R$ 142");
            }
            else if (salario > 2800.0 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }
            else if (salario > 3751.0 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }

            int mes = 5;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }






            Console.ReadLine();

        }
    }
}
