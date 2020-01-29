using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabrica.FabricasConcretas
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            throw new NotImplementedException();
        }

        public ICheckbox CreateCheckbox()
        {
            throw new NotImplementedException();
        }
    }
}
