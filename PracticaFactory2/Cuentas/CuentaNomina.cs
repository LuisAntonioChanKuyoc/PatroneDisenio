using PracticaFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFactory2.Cuentas
{
   public class CuentaNomina : ICuenta
    {
        private readonly int _numCuenta;

        public CuentaNomina(int numCuenta)
        {
            _numCuenta = numCuenta;
        }

        public void RetirarFondos(float fFondos)
        {
            Console.WriteLine($"El cliente hizo un retiro de ${fFondos} de la cuenta {_numCuenta} de NOMINA");
        }
    }
}
