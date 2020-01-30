using System;

namespace PatronBuilder.TipoResultado
{
    public  class Access
    {
        private string _cadena;
        public Access(string cadena)
        {
            _cadena = cadena;
        }

        public void Imprimir()
        {
            Console.WriteLine(_cadena);
        }
    }
}
