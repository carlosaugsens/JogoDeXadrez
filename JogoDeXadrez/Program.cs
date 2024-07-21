using Tabuleiro;
using JogoXadrez;

namespace JogoDeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroT tab = new TabuleiroT(8, 8);

            tab.ColocarPeca(new Rei(tab, Cor.Preta),new Posicao(0,5));

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            Tela.ImprimirTabuleiro(tab);
        }
    }
}