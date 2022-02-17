using System;

namespace exDiamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Início e entrada do número.

            /*Console.WriteLine("Uma obra de arte.");
            Console.WriteLine("Digite um número impar:");
            string strtamanhoDiamante = Console.ReadLine();
            int tamanhoDiamante = Convert.ToInt32(strtamanhoDiamante);
            Console.WriteLine();
            */
            #endregion

            #region caso o número seja par
            /*if (tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("Esse número é par.");
                Console.ReadLine();
            }
            */
            #endregion
            int quantidadeDeTermos = 7;
            int tamanhoDiamante = 7;
            
            int linha = 1;
            int quantidadeDeTermosNaLinha = linha;
            //#region caso o número seja ímpar.
            //else
            {

                #region código que desenha a parte superior do diamante

                //int quantidadeInicialdeEspacos = (tamanhoDiamante - 1) / 2;

                

                int quantidadeDeLinhasSuperior = tamanhoDiamante - 1;

                //for ( linha = 1; linha <= quantidadeDeLinhasSuperior; linha++)
                for (linha = 0; linha < quantidadeDeLinhasSuperior; linha++)
                {
                    if (linha % 2 == 0)
                    {
                        Console.WriteLine();
                    }
                    else if (linha % 2 != 0)
                    {
                        for (int i = 1; i <= quantidadeDeTermosNaLinha; i++)
                        {
                            for (int termo = 1; termo <= linha; termo++) {
                                if (termo == 1 || termo == quantidadeDeTermosNaLinha)
                                    Console.Write("X");
                                
                                else if (termo > 1 || termo < quantidadeDeTermosNaLinha)
                                            Console.Write(" ");
                            }

                        }
                    }
                    /*for (int i = 2; i < quantidadeDeTermosNaLinha; i++)
                    {
                        Console.Write(" ");
                    }
                    */
                    // quantidadeDeTermosNaLinha += 2;

                    //quantidadeInicialdeX += 2;

                    //Console.WriteLine();
                    
                }
                

                #endregion
                /*
                                 #region código que desenha a linha do meio

                                 for (int coluna = 0; coluna < tamanhoDiamante; coluna++)
                                 {
                                     Console.Write("X");
                                 }
                                 Console.WriteLine();

                                 quantidadeInicialdeEspacos++;
                                 quantidadeInicialdeX -= 2;

                                 #endregion

                                 #region código que desenha a parte inferior do diamante

                                 for (int linha = 0; linha < quantidadeDeLinhasSuperior; linha++)
                                 {
                                     for (int i = 0; i < quantidadeInicialdeEspacos; i++)
                                     {
                                         Console.Write(" ");
                                     }
                                     for (int i = 0; i < quantidadeInicialdeX; i++)
                                     {
                                         Console.Write("X");
                                     }

                                     quantidadeInicialdeEspacos++;
                                     quantidadeInicialdeX -= 2;

                                     Console.WriteLine();
                                 }

                                 #endregion

                                 Console.WriteLine();
                                 Console.WriteLine();
                                 Console.WriteLine("Pressione enter para sair.");
                                 Console.ReadLine();
                             }
                             #endregion


                            /*
                            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                            char[] letraimpressa= alfabeto.ToCharArray();

                            Console.WriteLine("Digite uma letra.");
                            string strletraEscolhida = Console.ReadLine();
                            char letraEscolhida = Convert.ToChar(strletraEscolhida);



                                for (int i = 0; i < letraEscolhida; i++)
                                {
                                    for(int j = 0; j < letraimpressa.Length; j++)
                                    {
                                        Console.Write(letraimpressa[j]);

                                    }

                                }

                    
                 */
                Console.ReadKey();
            }
        }
    }
}