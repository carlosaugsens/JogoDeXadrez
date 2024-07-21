using Tabuleiro;
namespace JogoXadrez
{
    internal class Rei : Peca
    {
        public Rei(TabuleiroT tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
