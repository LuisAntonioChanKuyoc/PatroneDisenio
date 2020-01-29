using CursoPatrones.Botones;
using System;

namespace CursoPatrones.Fabrica
{
    public class Windows:IButton
    {
        public void Onclick()
        {
            Console.WriteLine("Windows Onclick");

        }

        public void render()
        {
            Console.WriteLine("Windows render");

        }
    }
}
