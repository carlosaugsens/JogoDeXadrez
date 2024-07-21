using Tabuleiro;
namespace JogoXadrez
{
    internal class Torre : Peca
    {
        public Torre(TabuleiroT tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
