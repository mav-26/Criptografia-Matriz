using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QubrarCriptografiaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz x = new Matriz();

            string Primeira = "";
            string Segunda = "";
            int Colunas = 0;
            int indice = 0;
            int[,] chave = new int[2, 2];

            Console.WriteLine("1 - Descriptografar matriz");
            Console.WriteLine("2 - Obter Frase");
            Console.WriteLine("3 - Para sair do programa");
            indice = int.Parse(Console.ReadLine());

            while (indice != 3)
            {
                Console.Clear();
                switch (indice)
                {
                    case 1:
                        Primeira = "";
                        Segunda = "";
                        Colunas = 0;

                        Console.WriteLine("Matriz Chave:");
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                chave[i, j] = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (i == 0)
                                {
                                    Primeira += chave[i, j].ToString() + " ";
                                    Console.Write(Primeira);
                                }
                                else
                                {
                                    Segunda += chave[i, j].ToString() + " ";
                                    Console.WriteLine(Primeira);
                                    Console.Write(Segunda);
                                }
                            }
                        }
                        Console.Clear();

                        Console.Write("Numero de Colunas da matriz criptografada: ");
                        Colunas = int.Parse(Console.ReadLine());
                        int[,] Criptografado = new int[2, Colunas];
                        Console.Clear();

                        Console.WriteLine("Matriz Criptografada:");
                        Primeira = "";
                        Segunda = "";
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < Colunas; j++)
                            {
                                Criptografado[i, j] = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (i == 0)
                                {
                                    Primeira += Criptografado[i, j].ToString() + " ";
                                    Console.Write(Primeira);
                                }
                                else
                                {
                                    Segunda += Criptografado[i, j].ToString() + " ";
                                    Console.WriteLine(Primeira);
                                    Console.Write(Segunda);
                                }
                            }
                        }

                        int[,] resultado = x.MultiplicarMatrizes(chave, Criptografado, Colunas);
                        Primeira = "";
                        Segunda = "";
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < Colunas; j++)
                            {
                                Console.Clear();
                                if (i == 0)
                                {
                                    Primeira += resultado[i, j].ToString() + " ";
                                    Console.Write(Primeira);
                                }
                                else
                                {
                                    Segunda += resultado[i, j].ToString() + " ";
                                    Console.WriteLine(Primeira);
                                    Console.Write(Segunda);
                                }
                            }
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    
                    case 2:
                        Primeira = "";
                        Segunda = "";
                        Colunas = 0;

                        Console.Write("Número de colunas: ");
                        Colunas = int.Parse(Console.ReadLine());
                        x.Colunas = Colunas;
                        Console.Clear();

                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < Colunas; j++)
                            {                             
                                x.M[i, j] = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (i == 0)
                                {
                                    Primeira += x.M[i, j].ToString() + " ";
                                    Console.Write(Primeira);
                                }
                                else
                                {
                                    Segunda += x.M[i, j].ToString() + " ";
                                    Console.WriteLine(Primeira);
                                    Console.Write(Segunda);
                                }
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine(x.Frases());
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();

                Console.WriteLine("1 - Descriptografar matriz");
                Console.WriteLine("2 - Obter Frase");
                indice = int.Parse(Console.ReadLine());
            }        
        }
    }
}