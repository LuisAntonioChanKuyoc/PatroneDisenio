using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Productos
{
    public class WinCheckbox : ICheckbox
    {
        public string UsarCheckBox()
        {
            return "resultado checkbox de windows.";

        }
    }
}
