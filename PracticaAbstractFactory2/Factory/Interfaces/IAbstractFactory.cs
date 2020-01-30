using PracticaAbstractFactory2.Shape.Interfaces;

namespace PracticaAbstractFactory2.Factory
{
    public interface IAbstractFactory
    {
        /// <summary>
        /// Método que obtiene la forma de rectangulo
        /// </summary>
        /// <returns>La forma de rectangulo</returns>
        IShape getShapeRectangle();

        /// <summary>
        /// Método que obtiene la forma de cuadrado
        /// </summary>
        /// <returns>La forma de cuadro</returns>
        IShape getShapeSquare();
    }
}
