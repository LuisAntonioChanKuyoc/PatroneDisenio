using PracticaAbstractFactory2.Shape.Interfaces;
using System;

namespace PracticaAbstractFactory2.Shape
{
    public class RoundedRectangle : IShape
    {
        /// <summary>
        /// Dibuja la forma de un rectangulo redondeada
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Desde RoundedRectangle");

        }
    }
}
