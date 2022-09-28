using System;
using tabuleiro;


namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
