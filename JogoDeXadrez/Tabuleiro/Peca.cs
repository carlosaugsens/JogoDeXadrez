namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public TabuleiroT Tab { get; protected set; }

        public Peca(TabuleiroT tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }
    }
}
