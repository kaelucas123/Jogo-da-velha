using System;
using System.Text;

namespace Jogo_Da_Velha.Entities
{
    internal class Tabuleiro
    {

        public Peca a1 = new Peca();
        public Peca a2 = new Peca();
        public Peca a3 = new Peca();

        public Peca b1 = new Peca();
        public Peca b2 = new Peca();
        public Peca b3 = new Peca();

        public Peca c1 = new Peca();
        public Peca c2 = new Peca();
        public Peca c3 = new Peca();

        bool jogada = true;
        int[,] n = new int[3, 3];
        public string send, title, mensagem;
        public bool jogavel = true;
        public int jogadaCont;
        //=====================================================
        public Tabuleiro()
        {

        }

        void change(Peca peca, string nome)
        {
            if (peca.alteravel)
            {
                jogada = !jogada;
                peca.mudarValor(send);
                peca.alteravel = false;
                title = "Jogada executada!!";
                mensagem = $" Peça |{peca.valor}| registrada na casa |{nome}|";
                jogadaCont++;
            }
        }
        void mensagemDeVitoria(string ganhador)
        {
            mensagem = $"\n\n\n                         {ganhador} ganhou!\n\n\n\n";
            jogavel = false;
        }
        void verifica(int id, string peca)
        {
            if (n[0, 0] == id && n[0, 1] == id && n[0, 2] == id)
            {
                mensagemDeVitoria(peca);
            }
            else if (n[1, 0] == id && n[1, 1] == id && n[1, 2] == id)
            {
                mensagemDeVitoria(peca);
            }
            else if (n[2, 0] == id && n[2, 1] == id && n[2, 2] == id)
            {
                mensagemDeVitoria(peca);
            }
            //===============================================================
            else if (n[0, 0] == id && n[1, 0] == id && n[2, 0] == id)
            {
                mensagemDeVitoria(peca);
            }
            else if (n[0, 1] == id && n[1, 1] == id && n[2, 1] == id)
            {
                mensagemDeVitoria(peca);
            }
            else if (n[2, 2] == id && n[2, 2] == id && n[2, 2] == id)
            {
                mensagemDeVitoria(peca);
            }
            //===============================================================
            else if (n[0, 0] == id && n[1, 1] == id && n[2, 2] == id)
            {
                mensagemDeVitoria(peca);
            }
            else if (n[0, 2] == id && n[1, 1] == id && n[2, 0] == id)
            {
                mensagemDeVitoria(peca);
            }
            if (jogadaCont == 9)
            {
                mensagem = "emptate";
            }
        }

        public void jogar(string pos)
        {
            Console.Clear();
            switch (pos)
            {
                case "a1":
                    change(a1, "A1");
                    n[0, 0] = a1.id;
                    break;
                case "a2":
                    change(a2, "A2");
                    n[0, 1] = a2.id;
                    break;
                case "a3":
                    change(a3, "A3");
                    n[0, 2] = a3.id;
                    break;
                //============================================
                case "b1":
                    change(b1, "B1");
                    n[1, 0] = b1.id;
                    break;
                case "b2":
                    change(b2, "B2");
                    n[1, 1] = b2.id;
                    break;
                case "b3":
                    change(b3, "B3");
                    n[1, 2] = b3.id;
                    break;
                //============================================
                case "c1":
                    change(c1, "C1");
                    n[2, 0] = c1.id;
                    break;
                case "c2":
                    change(c2, "C2");
                    n[2, 1] = c2.id;
                    break;
                case "c3":
                    change(c3, "C3");
                    n[2, 2] = c3.id;
                    break;
                //============================================
                default:
                    title = "Jogada não executada :(";
                    mensagem = "Digite um valor válido.";
                    break;
            }
            verifica(1, "X");
            verifica(2, "O");

        }
        void limpar()
        {
            a1.id = 0;
            a1.valor = " ";
            a2.id = 0;
            a2.valor = " ";
            a3.id = 0;
            a3.valor = " ";

            b1.id = 0;
            b1.valor = " ";
            b2.id = 0;
            b2.valor = " ";
            b3.id = 0;
            b3.valor = " ";

            c1.id = 0;
            c2.id = 0;
            c3.id = 0;
            c1.valor = " ";
            c2.valor = " ";
            c3.valor = " ";
            mensagem = " ";
            title = " ";
        }

        public void resetarTabuleiro(bool iniciar)
        {
            if (iniciar)
            {
                limpar();
            }
            else
            {
                mensagem = "Obrigado por jogar";
            }
        }
        public override string ToString()
        {
            send = jogada ? "X" : "O";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"|==========================|Tabuleiro|==============================| \n");
            sb.AppendLine("                             1   2   3");
            sb.AppendLine($"                          A  {a1} | {a2} | {a3} ");
            sb.AppendLine("                            ───────────");
            sb.AppendLine($"                          B  {b1} | {b2} | {b3} ");
            sb.AppendLine("                            ───────────");
            sb.AppendLine($"                          C  {c1} | {c2} | {c3} ");
            sb.AppendLine($"\n|===========================|Jogada|================================|");
            sb.AppendLine($"\n\n                         Vez do {send} jogar.");
            sb.AppendLine($"\n\n|==========================|Relatório|==============================|");
            sb.AppendLine($"                      {title}                                         ");
            sb.AppendLine($"                   {mensagem}                                         ");
            sb.AppendLine($"|===================================================================|");


            return sb.ToString();
        }
    }
}

//sb.AppendLine("                             1   2   3");
//sb.AppendLine($"                          A  {n[0, 0]} | {n[0, 1]} | {n[0, 2]} ");
//sb.AppendLine("                            ───────────");
//sb.AppendLine($"                          B  {n[1, 0]} | {n[1, 1]} | {n[1, 2]} ");
//sb.AppendLine("                            ───────────");
//sb.AppendLine($"                          C  {n[2, 0]} | {n[2, 1]} | {n[2, 2]} ");
