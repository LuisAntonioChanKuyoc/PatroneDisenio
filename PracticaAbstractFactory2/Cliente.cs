using PracticaAbstractFactory2.Factory;
using System;

namespace PracticaAbstractFactory2
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("Cliente: Prueba de código de cliente con la fabrica de Shape...");
            IAbstractFactory shape = new ShapeFactory();
            new FactoryProducer(shape).getFactory();


            Console.WriteLine("\n\nCliente: Prueba de código de cliente con la fabrica de RoundedShape...");
            IAbstractFactory roundedShapeFactory = new RoundedShapeFactory();
            new FactoryProducer(roundedShapeFactory).getFactory();

            Console.ReadLine();
        }
    }
}
