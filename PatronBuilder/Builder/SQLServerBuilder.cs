using PatronBuilder.Interfaces;
using PatronBuilder.TipoResultado;

namespace PatronBuilder.Builder
{
    public class SQLServerBuilder : IBuilder
    {
        private string CadenaConexion = "";
        public void ObtenerServidor(string servidor)
        {
            CadenaConexion += $"Server={servidor};";
        }

        public void ObtenerTiempoEspera(int Tiempo)
        {
            CadenaConexion += $"Connection Timeout={Tiempo};";
        }

        public void ObtenerUsuario(string UsuarioId)
        {
            CadenaConexion += $"User ID={UsuarioId};";
        }

        public void ObtenerContrasenia(string contrasena)
        {
            CadenaConexion += $"Password={contrasena};";
        }

        public void ObtenerBaseInicial(string Base)
        {
            CadenaConexion += $"Database={Base};";
        }

        public void ObtenerConexionConfiable(bool lConfiable)
        {
            CadenaConexion += $"Trusted_Connection={lConfiable};";
        }

        public SQLServer GetResult()
        {
            return new SQLServer(CadenaConexion);
        }
    }
}
