using System;

namespace Tabuleiro
{
    internal class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string msg) : base(msg) { }
    }
}
