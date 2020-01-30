using PracticaAbstractFactory2.Shape.Interfaces;
using System;

namespace PracticaAbstractFactory2.Shape
{
    public class Square : IShape
    {
        /// <summary>
        /// Dibuja la forma de un cuadrado
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Desde Square");
        }
    }
}
