namespace PatronBuilder.Interfaces
{
    public interface IBuilder
    {
        void ObtenerServidor(string servidor);

        void ObtenerTiempoEspera(int Tiempo);
        void ObtenerUsuario(string UsuarioId);
        void ObtenerContrasenia(string contrasena);
        void ObtenerBaseInicial(string Base);
        void ObtenerConexionConfiable(bool lConfiable);
    }
}
