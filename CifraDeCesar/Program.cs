using System;

namespace CifraDeCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;
            int cifra = 0;
            int numCrt = 0;
            int num = 0;

            Console.WriteLine("BEM VINDO AO SISTEMA DE CRIPTOGRAFIA UTILIZANDO CRIFA DE CESAR!!! \n");

            while (opcoes != 9)
            {

                Console.WriteLine("Digite 1 para Definir uma Cifra.");
                Console.WriteLine("Digite 2 para Criptografar.");
                Console.WriteLine("Digite 3 para Descriptografar.");
                Console.WriteLine("Digite 4 para encerrar o sistema. \n");

                while (!int.TryParse(Console.ReadLine(), out opcoes))
                {
                    Console.WriteLine("Insira apenas números inteiros.");
                    Console.WriteLine("Digite a sua opção novamente.");
                }

                if (opcoes == 1)
                {
                    Console.WriteLine("\n Digite a sua cifra");
                    while (!int.TryParse(Console.ReadLine(), out cifra))
                    {
                        Console.WriteLine("Insira apenas números inteiros.");
                        Console.WriteLine("Digite a sua Cifra novamente.");
                    }
                    Console.WriteLine("\n");
                }

                else if (opcoes == 2)
                {
                    string criptografar = "";
                    string criptografia = "";
                    Console.WriteLine("\n Digite o texto a ser Criptografado:");
                    criptografar = Console.ReadLine();
                    numCrt = criptografar.Length;
                    for (int i = 0; i < numCrt; i++)
                    {
                        num = Convert.ToInt16(criptografar[i]) + cifra;
                        criptografia += Convert.ToChar(num);
                    }
                    Console.WriteLine("\n TEXTO CRIPTOGRAFADO => " + criptografia + "\n");

                }

                else if (opcoes == 3)
                {
                    string descriptografia = "";
                    string descriptografado = "";
                    Console.WriteLine("\n Digite o texto a ser Descriptografado:");
                    descriptografia = Console.ReadLine();
                    numCrt = descriptografia.Length;
                    for (int i = 0; i < numCrt; i++)
                    {
                        num = Convert.ToInt16(descriptografia[i]) - cifra;
                        descriptografado += Convert.ToChar(num);
                    }
                    Console.WriteLine("\n TEXTO DESCRIPTOGRAFADO => " + descriptografado + "\n");
                }
                else if (opcoes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n Pressione ENTER para encerrar a aplicação.");
                }
                else
                    Console.WriteLine("\n Opção inválida!");
            }

        }
    }
}

