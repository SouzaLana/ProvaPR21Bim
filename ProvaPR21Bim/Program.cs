using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, op, num1=0, i=0, t=2, n = int.MinValue, n1 = int.MaxValue, v=0, p=1, cont=0, r=1, j=0;

            Console.WriteLine("Escolha uma questão: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite um número inteiro: ");
                    num = int.Parse(Console.ReadLine());

                    if (num >= 0)
                    {
                        Console.WriteLine(num);
                    }
                    else
                    {
                        num1 = num * -1;
                        Console.WriteLine(num1);
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite um número inteiro: ");
                    num = int.Parse(Console.ReadLine());

                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("O número é multiplo de 3 e 5");
                    }
                    else if (num % 7 == 0 && num % 4 == 0)
                    {
                        Console.WriteLine("O número é multiplo de 4 e 7");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("O número é divisível de 3");
                    }
                    if (num % 4 == 0)
                    {
                        Console.WriteLine("O número é divisível de 4");
                    }
                    if (num % 5 == 0)
                    {
                        Console.WriteLine("O número é divisível de 5");
                    }
                    if (num % 7 == 0)
                    {
                        Console.WriteLine("O número é divisível de 7");
                    }
                    else
                    {
                        Console.WriteLine("O número apresenta uma impossibilidade de divisão!");
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    for (; i <= 2;)
                    {
                        Console.WriteLine("Digite um número: ");
                        num = int.Parse(Console.ReadLine());
                        i++;

                        if (num > n)
                        {
                            num1 = num;
                        }
                        if (num > num1)
                        {
                            num1 = num;
                        }
                        if (num > num1)
                        {
                            num1 = num;
                        }
                    }
                    Console.WriteLine(num1);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Digite um número de 1 a 7 (que equivale a um dia da semana): ");
                    num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Domingo: ");
                            Console.WriteLine("assistir TV");
                            break;
                        case 2:
                            Console.WriteLine("Segunda: ");
                            Console.WriteLine("Filosofia");
                            Console.WriteLine("Português");
                            Console.WriteLine("Matemática");
                            break;
                        case 3:
                            Console.WriteLine("Terça: ");
                            Console.WriteLine("Química");
                            Console.WriteLine("História");
                            Console.WriteLine("IMI");
                            break;
                        case 4:
                            Console.WriteLine("Quarta: ");
                            Console.WriteLine("Biologia");
                            Console.WriteLine("Português");
                            Console.WriteLine("PR2");
                            break;
                        case 5:
                            Console.WriteLine("Qunta: ");
                            Console.WriteLine("Física");
                            Console.WriteLine("RDC");
                            Console.WriteLine("Sociologia");
                            break;
                        case 6:
                            Console.WriteLine("Sexta: ");
                            Console.WriteLine("Geografia");
                            Console.WriteLine("Matemática");
                            Console.WriteLine("BDS");
                            break;
                        case 7:
                            Console.WriteLine("Sábado: ");
                            Console.WriteLine("Jogar basquete");
                            break;
                        default:
                            Console.WriteLine("Numero inválido!");
                            break;
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    for (; t != 0;)
                    {
                        Console.WriteLine("Digite um número inteiro: ");
                        num = int.Parse(Console.ReadLine());

                        if (num > n)
                        {
                            n = num;
                        }
                        else if (num < n1)
                        {
                            num1 = num;
                        }

                        Console.WriteLine("Digite 0 para parar e 3 para continuar; ");
                        t = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("O maior número é: " + n);
                    Console.WriteLine("O menor número é: " + num1);
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Digite um número: ");
                    num = int.Parse(Console.ReadLine());

                    for(; i == num; i++)
                    {
                        if(num % p == 0)
                        {
                            v += p;
                        } 
                    }
                    if (v == num)
                    {
                        Console.WriteLine("Esse é um número perfeito");
                    }
                    else
                    {
                        Console.WriteLine("Esse não é um número perfeito");
                    }
                    Console.ReadKey();
                    break;
                case 7:
                    for (; t != 0;)
                    {
                        Console.WriteLine("Digite um número: ");
                        num = int.Parse(Console.ReadLine());

                        j = cont++;

                        if(num % 2 == 0)
                        {
                            num1 += num;
                        }

                        Console.WriteLine("Digite 0 para parar e 3 para continuar: ");
                        t = int.Parse(Console.ReadLine());
                    }

                    r = num1 / j;

                    if (r == 0)
                    {
                        Console.WriteLine("Não foi possível calcular a média");
                    }
                    else
                    {
                        Console.WriteLine("A média é: " + r);
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
