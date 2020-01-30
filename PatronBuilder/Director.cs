using PatronBuilder.Interfaces;

namespace PatronBuilder
{
    public class Director
    {
        public void CrearConexion(IBuilder builder)
        {
            builder.ObtenerServidor("www.Servidor.com");
            builder.ObtenerTiempoEspera(200);
            builder.ObtenerUsuario("Antonio");
            builder.ObtenerContrasenia("Chan");
            builder.ObtenerBaseInicial("myDB");
            builder.ObtenerConexionConfiable(true);
        }
    }
}
