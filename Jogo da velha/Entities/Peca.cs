using System;
using System.Text;


namespace Jogo_Da_Velha.Entities
{
    internal class Peca
    {
        public string valor = " ";
        public int id = 0;
        public bool alteravel = true;
        StringBuilder sb = new StringBuilder();

        public Peca()
        {

        }

        public void mudarValor(string valor)
        {
            if (id == 0)
            {
                this.valor = valor;
                if (valor == "X")
                {
                    id = 1;
                }
                else if (valor == "O")
                {
                    id = 2;
                }
            }
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return valor;

        }



    }
}

