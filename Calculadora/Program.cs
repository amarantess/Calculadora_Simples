using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            double num1, num2, resultado, op;
            string opcao;

            //Cabeçalho
            Console.WriteLine("---------------");
            Console.WriteLine("  CALCULADORA  ");
            Console.WriteLine("---------------");
            Console.WriteLine("Tecle ENTER");
            Console.ReadLine();
            Console.Clear();

        Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escolha uma operação");
            Console.WriteLine("Operação 1: Adição");
            Console.WriteLine("Operação 2: Subtração");
            Console.WriteLine("Operação 3: Multiplicação");
            Console.WriteLine("Operação 4: Divisão");
            op = double.Parse(Console.ReadLine());
            Console.Clear();

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, opção inválida");
                    break;

                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                case 4:

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;
            }

            Console.Write("Continuar calculando? (S / N) ");
            opcao = Console.ReadLine();
           
            if (opcao == "S" || opcao == "s")
            {
                goto Inicio;
            }
        }
    }
}
