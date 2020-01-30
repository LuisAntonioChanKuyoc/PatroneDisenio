using System;

namespace PatronBuilder.TipoResultado
{
    public class MySQL
    {
        private string _cadena;
        public MySQL(string cadena)
        {
            _cadena = cadena;
        }

        public void Imprimir()
        {
            Console.WriteLine(_cadena);
        }
    }
}
