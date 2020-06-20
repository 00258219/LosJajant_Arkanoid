using System;

namespace Arkanoid.Controlador
{
    public class MinimizingPauseException : Exception
    {
        public MinimizingPauseException(string Ex) : base(Ex)
        {
        }
    }
}