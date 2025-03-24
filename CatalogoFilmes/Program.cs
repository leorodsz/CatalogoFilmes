using System;
using System.Diagnostics;

namespace CatalogoFilmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int op2 = 0;

            do
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Catalogo de filmes");
                Console.WriteLine("=======================");
                Console.WriteLine("\n");
                Console.WriteLine("Escolha o filme: ");
                Console.WriteLine("[1] Minecraft");
                Console.WriteLine("[2] FNAF");
                Console.WriteLine("[3] It the thing");
                Console.WriteLine("[4] Sair");
                
                // Captura a entrada do usuário e converte para inteiro
                bool entradaValida = int.TryParse(Console.ReadLine(), out op);

                if (!entradaValida)
                {
                    Console.WriteLine("\nOpção inválida! Digite um número entre 1 e 4.\n");
                    continue;
                    
                }
               
                Thread.Sleep(1000);
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nVocê escolheu o filme do Minecraft");
                        Console.WriteLine(MovieContent.Conteudo("Minecraft"));
                        Console.WriteLine(MovieContent.Horario("Minecraft"));
                        Console.WriteLine("\nDeseja imprimir seu ingresso?");
                        Console.WriteLine("[1] Sim  ||  [2] Não");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            
                            string ingresso = MovieContent.ImprimirIngresso("Minecraft");
                            Console.WriteLine(ingresso);
                            // Abre o arquivo no bloco de notas
                            Process.Start("notepad.exe", "voucher.txt");
                        }
                        else if (op2 == 2)
                        {
                            Console.WriteLine("Ingresso não impresso");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida! Digite apenas 1 ou 2.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nVocê escolheu o filme do FNAF");
                        Console.WriteLine(MovieContent.Conteudo("FNAF"));
                        Console.WriteLine(MovieContent.Horario("FNAF"));
                        Console.WriteLine("\nDeseja imprimir seu ingresso?");
                        Console.WriteLine("[1] Sim  ||  [2] Não");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            // Chama o método para imprimir o ingresso e salvar no arquivo
                            string ingresso = MovieContent.ImprimirIngresso("FNAF");
                            Console.WriteLine(ingresso);
                            // Abre o arquivo no bloco de notas
                            Process.Start("notepad.exe", "voucher.txt");
                        }
                        else if (op2 == 2)
                        {
                            Console.WriteLine("Ingresso não impresso");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida! Digite apenas 1 ou 2.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nVocê escolheu o filme do It the thing");
                        Console.WriteLine(MovieContent.Conteudo("It the thing"));
                        Console.WriteLine(MovieContent.Horario("It the thing"));
                        Console.WriteLine("\nDeseja imprimir seu ingresso?");
                        Console.WriteLine("[1] Sim  ||  [2] Não");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            // Chama o método para imprimir o ingresso e salvar no arquivo
                            string ingresso = MovieContent.ImprimirIngresso("It the thing");
                            Console.WriteLine(ingresso);
                            // Abre o arquivo no bloco de notas
                            Process.Start("notepad.exe", "voucher.txt");
                        }
                        else if (op2 == 2)
                        {
                            Console.WriteLine("Ingresso não impresso");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida! Digite apenas 1 ou 2.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nSaindo do programa...\n");
                        Console.WriteLine("Obrigado por usar nosso catálogo de filmes!");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Digite um número entre 1 e 4.\n");
                        break;
                }

                Thread.Sleep(1000);
                Console.Clear();

            } while (op != 4);
        }
    }
}