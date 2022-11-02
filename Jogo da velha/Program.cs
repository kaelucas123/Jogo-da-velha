using System;
using Jogo_Da_Velha.Entities;

namespace Jogo_da_velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro();

            string comando;

            void update()
            {
                Console.WriteLine(tab);
            }
            while(tab.jogavel)
            {
                update();
                comando = Console.ReadLine();
                tab.jogar(comando.ToLower());
            }
            Console.Clear();
            Console.WriteLine(tab.mensagem);
            string resp;
            bool resposta;
            while (true)
            {
                Console.WriteLine("\n\n Você gostaria de jogar novamente? (s/n)");
                resp = Console.ReadLine().ToLower();
                if(resp == "s")
                {
                    resposta = true;
                    tab.resetarTabuleiro(resposta);
                    Console.WriteLine(tab);
                    break;
                }
                else if(resp == "n")
                {
                    resposta= false;
                    tab.resetarTabuleiro(resposta);
                }
                else 
                {
                    Console.WriteLine("Digite um valor válido");
                }
            }
        }
    }
}
