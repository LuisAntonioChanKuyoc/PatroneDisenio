using PracticaAbstractFactory2.Shape;
using PracticaAbstractFactory2.Shape.Interfaces;

namespace PracticaAbstractFactory2.Factory
{
    /// <summary>
    /// Fabrica para obtener las Formas normales
    /// </summary>
    public class ShapeFactory : IAbstractFactory
    {
        /// <summary>
        /// Método para obtener un rectangulo
        /// </summary>
        /// <returns>Rectangulo</returns>
        public IShape getShapeRectangle()
        {
            return new Rectangle();
        }

        /// <summary>
        /// Método para obtener un Cuadrado
        /// </summary>
        /// <returns>Cuadrado</returns>
        public IShape getShapeSquare()
        {
            return new Square();
        }
    }
}
