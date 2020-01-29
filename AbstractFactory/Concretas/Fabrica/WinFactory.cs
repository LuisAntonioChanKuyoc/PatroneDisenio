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
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();

        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();

        }
    }
}
