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
    }
}