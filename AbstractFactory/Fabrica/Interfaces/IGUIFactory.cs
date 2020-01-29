using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabrica
{
    public interface IGUIFactory
    {
        IButton CreateButton();

        ICheckbox CreateCheckbox();
    }
}
