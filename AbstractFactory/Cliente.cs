using AbstractFactory.Concretas.Fabrica;
using AbstractFactory.Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
  public  class Cliente
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Prueba de código de cliente con el primer tipo de fábrica...");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Probar el mismo código de cliente con el segundo tipo de fábrica...");
            ClientMethod(new MacFactory());
        }

        public void ClientMethod(IGUIFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckbox();

            Console.WriteLine(productA.UsarButton());
            Console.WriteLine(productB.UsarCheckBox());

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
