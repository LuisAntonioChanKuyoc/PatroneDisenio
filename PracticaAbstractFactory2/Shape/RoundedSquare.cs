using PracticaAbstractFactory2.Shape.Interfaces;
using System;

namespace PracticaAbstractFactory2.Shape
{
    public class RoundedSquare : IShape
    {
        /// <summary>
        /// Dibuja la forma de un cuadrado redondeada
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Desde RoundedSquare");

        }
    }
}
