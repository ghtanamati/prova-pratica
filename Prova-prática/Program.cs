using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_prática
{
    class Program
    {
        /* EXERCÍCIO 1.1
         static void Main(string[] args)
         {
            Console.WriteLine("Insira o código do produto");
            int codigoPeca = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o número de peças a ser comprado");
            int numPeca = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entre com o valor unitário do produto {codigoPeca}");
            double valorPeca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"VALOR A PAGAR: R$ {valorPeca * numPeca}");
        } */

        /* EXERCÍCIO 1.2
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o raio do círculo");
            double raioCirculo = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;

            double areaCirculo = pi * raioCirculo * raioCirculo;

            Console.WriteLine($"Área do Círculo: {areaCirculo.ToString("#.####")} cm²");
        }*/

        /* EXERCÍCIO 2.1
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o código do produto desejado");
            int codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a quantidade desejada");
            int qtdeProduto = Convert.ToInt32(Console.ReadLine());

            switch (codigoProduto)
            {
                case 1:
                    double precoProduto = 4;
                    Console.WriteLine($"Preço Total: R$ {precoProduto * qtdeProduto}");
                    break;

                case 2:
                    precoProduto = 4.5;
                    Console.WriteLine($"Preço Total: R$ {precoProduto * qtdeProduto}");
                    break;

                case 3:
                    precoProduto = 5;
                    Console.WriteLine($"Preço Total: R$ {precoProduto * qtdeProduto}");
                    break;

                case 4:
                    precoProduto = 2;
                    Console.WriteLine($"Preço Total: R$ {precoProduto * qtdeProduto}");
                    break;

                case 5:
                    precoProduto = 1.5;
                    Console.WriteLine($"Preço Total: R$ {precoProduto * qtdeProduto}");
                    break;
            }
        } */

        /* EXERCÍCIO 1.1 - SEGUNDO MÉTODO
        static void Main(string[] args)
        {
            double valorTotal = 0;
            int j = 1;

            Console.WriteLine("Insira o código do produto, o número de peças a ser comprado e o valor unitário");

            do
            {
                string stringValores = Console.ReadLine();

                string[] arrayValores = stringValores.Split(' ');

                double valorParcial = 1;

                for (int i = 1; i < (arrayValores.Length); i++)
                {
                    double valores = Convert.ToDouble(arrayValores[i]);

                    valorParcial = valorParcial * valores;
                }

                valorTotal = valorTotal + valorParcial;
                j = j + 1;

            } while (j < 3);
            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal}");
        }*/

        /* EXERCÍCIO 2.1 - SEGUNDO MÉTODO
        static void Main(string[] args)
        {
            string[] precoDosProdutos = {"4,00", "4,50", "5,00", "2,00", "1,50"};

            Console.WriteLine("Insira o código do produto desejado e a quantidade");
            string stringEntradas = Console.ReadLine();
            string[] arrayEntradas = stringEntradas.Split(' ');
            int qtdeProdutos = Convert.ToInt32(arrayEntradas[1]);

            double total = 1.0;

            switch (Convert.ToInt32(arrayEntradas[0]))
            {
                case 1:
                    total = Convert.ToDouble(precoDosProdutos[0]) * qtdeProdutos;
                    break;

                case 2:
                    total = Convert.ToDouble(precoDosProdutos[1]) * qtdeProdutos;
                    break;

                case 3:
                    total = Convert.ToDouble(precoDosProdutos[2]) * qtdeProdutos;
                    break;

                case 4:
                    total = Convert.ToDouble(precoDosProdutos[3]) * qtdeProdutos;
                    break;

                case 5:
                    total = Convert.ToDouble(precoDosProdutos[4]) * qtdeProdutos;
                    break;
            }
            Console.WriteLine($"Total: R$ {total}");
        }*/

        /* EXERCÍCIO 2.1 - TERCEIRO MÉTODO
        static void Main(string[] args)
        {
            string[] precoDosProdutos = { "4,00", "4,50", "5,00", "2,00", "1,50" };

            Console.WriteLine("Insira o código do produto desejado e a quantidade");

            string stringEntradas = Console.ReadLine();

            string[] arrayEntradas = stringEntradas.Split(' ');

            int qtdeProdutos = Convert.ToInt32(arrayEntradas[1]);
            
            double precoProduto = Convert.ToDouble(precoDosProdutos[(Convert.ToInt32(arrayEntradas[0])) - 1]);

            double total = qtdeProdutos * precoProduto;

            Console.WriteLine($"Total: R$ {total}");
        }*/


        /*EXERCÍCIO 2.2
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os três coeficientes de uma equação do segundo grau!");

            string stringEntradas = Console.ReadLine();

            string[] arrayEntradas = stringEntradas.Split(' ');

            double a = Convert.ToDouble(arrayEntradas[0]);
            double b = Convert.ToDouble(arrayEntradas[1]);
            double c = Convert.ToDouble(arrayEntradas[2]);
            double delta = (b * b) - (4 * a * c);

            if (a == 0)
            {
                Console.WriteLine("Impossível de calcular");
            }
            else if(delta < 0)
            {
                Console.WriteLine("Imposível de calcular");
            }
            else
            {
                double sqr_delta = Math.Sqrt(delta);
                double x1 = (-b + (sqr_delta)) / (2 * a);
                double x2 = (-b - (sqr_delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
        }*/

        /*EXERCÍCIO 3.1
        static void Main(string[] args)
        {
            int j = 0;
            do
            {
                Console.WriteLine("Insira a senha");
                string senha = Console.ReadLine();

                if (senha == "2002")
                {
                    Console.WriteLine("Acesso Permitido");
                    j = 1;
                }
                else
                {
                    Console.WriteLine("Senha Inválida\n");
                    j = 0;
                }
            } while (j != 1);
        }*/

        /*EXERCÍCIO 3.2*/
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho da lista a ser analisada");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrayDosNumeros = new int[n];

            Console.WriteLine("Insira os elementos da lista");
            for (int i = 0; i < n; i++)
            {
                int elemento = Convert.ToInt32(Console.ReadLine());
                arrayDosNumeros[i] = elemento;
            }

            int countIn = 0;
            int countOut = 0;
            foreach (int numero in arrayDosNumeros)
            {
                if (numero >= 10 && numero <=20)
                {
                    countIn = countIn + 1;
                }
                else
                {
                    countOut = countOut + 1;
                }
            }

            Console.WriteLine($"\n{countIn} in");
            Console.WriteLine($"{countOut} out");

        }
    }
}