using PatronBuilder.Builder;
using PatronBuilder.TipoResultado;
using System;

namespace PatronBuilder
{
    public  class Cliente
    {
        public void Main()
        {
            Director director = new Director();
            Console.WriteLine("Cadena de conexión del SQL Server");
            SQLServerBuilder CadenaBuilder = new SQLServerBuilder();
            director.CrearConexion(CadenaBuilder);
            SQLServer sQLServer = CadenaBuilder.GetResult();
            sQLServer.Imprimir();

            Console.WriteLine("\nCadena de conexión del MySQL ");
            MySQLBuilder CadenaMySQLBuilder = new MySQLBuilder();
            director.CrearConexion(CadenaMySQLBuilder);
            MySQL mySQL = CadenaMySQLBuilder.GetResult();
            mySQL.Imprimir();

            Console.WriteLine("\n Cadena de conexión del Access");

            AccessBuilder CadenaAccessBuilder = new AccessBuilder();
            director.CrearConexion(CadenaAccessBuilder);
            Access Access = CadenaAccessBuilder.GetResult();
            Access.Imprimir();

            Console.ReadLine();
        }
    }
}
