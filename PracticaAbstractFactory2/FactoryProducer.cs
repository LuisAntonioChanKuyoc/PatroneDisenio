using PracticaAbstractFactory2.Factory;
using PracticaAbstractFactory2.Shape.Interfaces;

namespace PracticaAbstractFactory2
{
    public class FactoryProducer
    {
        private readonly IAbstractFactory _abstractFactory;

        /// <summary>
        /// Método para intancia el tipo de fabrica
        /// </summary>
        /// <param name="abstractFactory">Interface para crear el tipo de fabrica</param>
        public FactoryProducer(IAbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }

        /// <summary>
        /// Para obtener las las fabricas y las formas que le coresponden
        /// </summary>
        public void getFactory()
        {
            IShape ShapeRectangle = _abstractFactory.getShapeRectangle();
            IShape ShapeSquare = _abstractFactory.getShapeSquare();

            ShapeRectangle.draw();
            ShapeSquare.draw();
        }
    }
}
