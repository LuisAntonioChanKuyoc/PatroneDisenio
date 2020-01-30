using PracticaFactory2.Fabrica;
using PracticaFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFactory2
{
    public class Cliente
    {
        public void Main()
        {
            ICuentaFactory cuentaAhorro = new CuentaAhorroFactory();
            ICuentaFactory cuentaCheques = new CuentaChequesFactory();
            ICuentaFactory cuentaNomina = new CuentaNominaFactory();

            CrearCuenta(cuentaAhorro, 57242.32f);
            CrearCuenta(cuentaCheques, 88242.32f);
            CrearCuenta(cuentaNomina, 67242.32f);

            Console.WriteLine();
            Console.ReadLine();
        }


        public void CrearCuenta(ICuentaFactory cuentaFactory, float fFondo)
        {
            ICuenta TipoCuenta = cuentaFactory.CrearInstancia();
            TipoCuenta.RetirarFondos(fFondo);
           
        }
    }
}
