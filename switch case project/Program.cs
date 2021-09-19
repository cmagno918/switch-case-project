using System;

namespace switch_case_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cor da sua camisa:");
            int x = int.Parse(Console.ReadLine());
            string camisa;
            Console.WriteLine("Qual a cor da sua Calça:");
            int y = int.Parse(Console.ReadLine());
            string calca;
            Console.WriteLine("Qual a cor da sua Cueca:");
            int z = int.Parse(Console.ReadLine());
            string cueca;
            Console.WriteLine("Qual a cor da sua meia:");
            int w = int.Parse(Console.ReadLine());
            string meia;
            


            switch (x)
            {
                case 1:
                    camisa = "Vermelha";
                    break;

                case 2:
                    camisa = "Azul";
                    break;

                case 3:
                    camisa = "Verde";
                    break;

                case 4:
                    camisa = "Amarelo";
                    break;
                default:
                    camisa = "Valor inválido";
                    break;

            }
            switch (y)
            {
                case 1:
                    calca = "Vermelha";
                    break;
                case 2:
                    calca = "Azul";
                    break;
                case 3:
                    calca = "Verde";
                    break;
                case 4:
                    calca = "Amarelo";
                    break;
                default:
                    calca = "Valor inválido";
                    break;
            }
            switch (z)
            {
                case 1:
                    cueca = "Vermelha";
                    break;
                case 2:
                    cueca = "Azul";
                    break;
                case 3:
                    cueca = "Verde";
                    break;
                case 4:
                    cueca = "Amarelo";
                    break;
                default:
                    cueca = "Valor inválido";
                    break;
            }
            switch (w)
            {
                case 1:
                    meia = "Vermelha";
                    break;
                case 2:
                    meia = "Azul";
                    break;
                case 3:
                    meia = "Verde";
                    break;
                case 4:
                    meia = "Amarelo";
                    break;
                default:
                    meia = "Valor inválido";
                    break;
            }
            Console.WriteLine(" Sua camisa é " + camisa + " Sua calça é: " + calca + " Sua cueca é " + cueca + " Sua meia é: " + meia  );

        }
            

        }

        }


