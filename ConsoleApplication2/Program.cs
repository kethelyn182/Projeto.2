using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string continuar = "s";
            Console.WriteLine("Calculadora em C#");

            do
            {

                Console.WriteLine("Digite o primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha as operações listadas abaixo: ");
                Console.WriteLine(" A - Adição");
                Console.WriteLine(" S - Subtração");
                Console.WriteLine(" M - Multiplicação");
                Console.WriteLine(" D - Divisão");
                Console.WriteLine("Qual a sua opção?");

                switch (Console.ReadLine())
                {
                    case "A":
                        Console.WriteLine("Seu resultado: {num1} + {num2} = " + (num1 + num2)); break;
                    case "S":
                        Console.WriteLine("Seu resultado: {num1} - {num2} = " + (num1 - num2)); break;
                    case "M":
                        Console.WriteLine("Seu resultado: {num1} * {num2} = " + (num1 * num2)); break;
                    case "D":
                        Console.WriteLine("Seu resultado: {num1} / {num2} = " + (num1 / num2)); break;

                }
                Console.WriteLine("Pressione a tecla s para calcular novamente");
                continuar = Console.ReadLine();
               
            } while ((continuar == "s" || continuar == "S"));
               }
            }
        }

    

