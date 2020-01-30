using System;

namespace PatronBuilder.TipoResultado
{
    public  class SQLServer
    {
        private string _cadena;
        public SQLServer(string cadena)
        {
            _cadena = cadena;
        }
        public void Imprimir()
        {
            Console.WriteLine(_cadena);
        }
    }
}
