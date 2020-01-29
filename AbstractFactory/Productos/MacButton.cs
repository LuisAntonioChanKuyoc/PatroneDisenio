using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Productos
{
   public class MacButton : IButton
    {
        public string UsarButton()
        {
            return "resultado button de mac.";

        }
    }
}
