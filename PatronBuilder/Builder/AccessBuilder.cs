using PatronBuilder.Interfaces;
using PatronBuilder.TipoResultado;

namespace PatronBuilder.Builder
{
    public class AccessBuilder : IBuilder
    {
        private string CadenaConexion = "";
        public void ObtenerServidor(string servidor)
        {
            CadenaConexion += $"Provider={servidor};";
        }

        public void ObtenerTiempoEspera(int Tiempo)
        {
            CadenaConexion += $"Locale Identifier={Tiempo};";
        }

        public void ObtenerUsuario(string UsuarioId)
        {
            CadenaConexion += $"User Id={UsuarioId};";
        }

        public void ObtenerContrasenia(string contrasena)
        {
            CadenaConexion += $"Password={contrasena};";
        }

        public void ObtenerBaseInicial(string Base)
        {
            CadenaConexion += $"Data Source={Base};";
        }

        public void ObtenerConexionConfiable(bool lConfiable)
        {
            CadenaConexion += $"Persist Security Info={lConfiable};";
        }

        public Access GetResult()
        {
            return new Access(CadenaConexion);
        }
    }
}
