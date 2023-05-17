using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QubrarCriptografiaMatriz
{
    internal class Matriz
    {
        public int Colunas = 0;
        public int[,] M = new int[2, 100];
        public int[,] Chave = new int[2, 2];

        public string Frases()
        {
            string[,] VetFrase = new string[2, 100];
            string Frase = " ";
            string FraseCompleta = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    switch (M[i, j])
                    {
                        case 0: Frase = " "; break;
                        case 1: Frase = "A"; break;
                        case 2: Frase = "B"; break;
                        case 3: Frase = "C"; break;
                        case 4: Frase = "D"; break;
                        case 5: Frase = "E"; break;
                        case 6: Frase = "F"; break;
                        case 7: Frase = "G"; break;
                        case 8: Frase = "H"; break;
                        case 9: Frase = "I"; break;
                        case 10: Frase = "J"; break;
                        case 11: Frase = "K"; break;
                        case 12: Frase = "L"; break;
                        case 13: Frase = "M"; break;
                        case 14: Frase = "N"; break;
                        case 15: Frase = "O"; break;
                        case 16: Frase = "P"; break;
                        case 17: Frase = "Q"; break;
                        case 18: Frase = "R"; break;
                        case 19: Frase = "S"; break;
                        case 20: Frase = "T"; break;
                        case 21: Frase = "U"; break;
                        case 22: Frase = "V"; break;
                        case 23: Frase = "W"; break;
                        case 24: Frase = "X"; break;
                        case 25: Frase = "Y"; break;
                        case 26: Frase = "Z"; break;
                        case 27: Frase = "Á"; break;
                        case 28: Frase = "É"; break;
                        case 29: Frase = "Í"; break;
                        case 30: Frase = "Ó"; break;
                        case 31: Frase = "Ú"; break;
                        case 32: Frase = "À"; break;
                        case 33: Frase = "Â"; break;
                        case 34: Frase = "Ê"; break;
                        case 35: Frase = "Ô"; break;
                        case 36: Frase = "Ã"; break;
                        case 37: Frase = "Õ"; break;
                        case 38: Frase = "Ç"; break;
                        case 39: Frase = "."; break;
                        case 40: Frase = ","; break;
                        case 41: Frase = ":"; break;
                        case 42: Frase = "?"; break;
                        case 43: Frase = "!"; break;
                    }

                    VetFrase[i, j] = Frase;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    FraseCompleta += VetFrase[i, j];
                }
            }
            return FraseCompleta;
        }

        public int[,] MultiplicarMatrizes(int[,] chave, int[,] MatrizCriptografado, int Coluna)
        {
            int chaveLinhas = 2;
            int chaveColunas = 2;
            int mColunas = Coluna;

            int[,] resultado = new int[chaveLinhas, mColunas];

            for (int i = 0; i < chaveLinhas; i++)
            {
                for (int j = 0; j < mColunas; j++)
                {
                    int soma = 0;
                    for (int k = 0; k < chaveColunas; k++)
                    {
                        soma += chave[i, k] * MatrizCriptografado[k, j];
                    }
                    resultado[i, j] = soma;
                }
            }

            return resultado;
        }
    }
}