using CursoPatrones.Botones;
using System;

namespace CursoPatrones.Fabrica
{
    public class HTML : IButton
    {
        public void Onclick()
        {
            Console.WriteLine("HTML Onclick");
            Console.ReadLine();

        }

        public void render()
        {
            Console.WriteLine("HTML render");
            Console.ReadLine();
        }
    }
}
