using PracticaAbstractFactory2.Shape;
using PracticaAbstractFactory2.Shape.Interfaces;

namespace PracticaAbstractFactory2.Factory
{
    /// <summary>
    /// Fabrica para obtener las Formas redondeadas
    /// </summary>
    public class RoundedShapeFactory : IAbstractFactory
    {
        /// <summary>
        /// Método para obtener un rectangulo redondeada
        /// </summary>
        /// <returns>Rectangulo redondeada</returns>
        public IShape getShapeRectangle()
        {
            return new RoundedRectangle();
        }

        /// <summary>
        /// Método para obtener un cuadrado redondeada
        /// </summary>
        /// <returns>Cuadrado redondeada</returns>
        public IShape getShapeSquare()
        {
            return new RoundedSquare();
        }
    }
}
