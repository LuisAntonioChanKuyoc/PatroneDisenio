using PracticaAbstractFactory2.Shape.Interfaces;
using System;

namespace PracticaAbstractFactory2.Shape
{
    public class Rectangle : IShape
    {
        /// <summary>
        /// Dibuja la forma del rectangulo
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Desde Rectangle");
        }
    }
}
