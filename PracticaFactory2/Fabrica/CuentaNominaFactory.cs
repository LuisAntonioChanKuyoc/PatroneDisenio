using PracticaFactory2.Cuentas;
using PracticaFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFactory2.Fabrica
{
    class CuentaNominaFactory : ICuentaFactory
    {
        public ICuenta CrearInstancia()
        {
            return new CuentaNomina(904003200);
        }
    }
}
