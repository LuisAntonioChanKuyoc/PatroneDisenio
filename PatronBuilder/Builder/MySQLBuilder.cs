using PatronBuilder.Interfaces;
using PatronBuilder.TipoResultado;

namespace PatronBuilder.Builder
{
    public class MySQLBuilder : IBuilder
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
            CadenaConexion += $"Uid={UsuarioId};";
        }

        public void ObtenerContrasenia(string contrasena)
        {
            CadenaConexion += $"Pwd={contrasena};";
        }

        public void ObtenerBaseInicial(string Base)
        {
            CadenaConexion += $"Database={Base};";
        }

        public void ObtenerConexionConfiable(bool lConfiable)
        {
            CadenaConexion += $"Encrypt={lConfiable};";
        }

        public MySQL GetResult()
        {
            return new MySQL(CadenaConexion);
        }
    }
}
