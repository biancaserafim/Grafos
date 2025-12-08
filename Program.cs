using System;

namespace MatrizGrafo
{
    class Program
    {
        static void imprimirMatriz(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    System.Console.Write(matriz[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        static int menu()
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1 - Mostrar Matriz");
            Console.WriteLine("2 - Verificar Reflexividade");
            Console.WriteLine("3 - Verificar Simetria");
            Console.WriteLine("4 - Mostrar R²");
            Console.WriteLine("5 - Verificar Transitividade");
            Console.WriteLine("6 - Mostrar R Infinito");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Grafo meuGrafo = new Grafo(10);
            meuGrafo.carregarMatrizDeArquivo("matrizSimetrica.txt");

            int opcao = 0;
            do
            {
                opcao = menu();

                switch (opcao)
                {
                    case 1:
                        meuGrafo.mostrarMatriz();
                        break;

                    case 2:
                        if (meuGrafo.eReflexiva())
                        {
                            Console.WriteLine("A relação é reflexiva");
                        }
                        else
                        {
                            Console.WriteLine("A relação NÃO é reflexiva");
                        }
                        break;

                    case 3:
                        if (meuGrafo.eSimetrica())
                        {
                            Console.WriteLine("A relação é simétrica");
                        }
                        else
                        {
                            Console.WriteLine("A relação NÃO é simétrica");
                        }
                        break;

                    case 4:
                        imprimirMatriz(meuGrafo.obterCaminho2());
                        break;

                    case 5:
                        if (meuGrafo.verificarTransitividade())
                        {
                            Console.WriteLine("A relação é transitiva");
                        }
                        else
                        {
                            Console.WriteLine("A relação NÃO é transitiva");
                        }
                        break;

                    case 6:
                        imprimirMatriz(meuGrafo.obterRInfinito());
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.ReadLine();
                Console.Clear();

            } while (opcao != 0);
        }
    }
}
