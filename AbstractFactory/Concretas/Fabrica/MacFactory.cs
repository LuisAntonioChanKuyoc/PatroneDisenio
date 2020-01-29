using AbstractFactory.Fabrica;
using AbstractFactory.Interfaces;
using AbstractFactory.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concretas.Fabrica
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();

        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
