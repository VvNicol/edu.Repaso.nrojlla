using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.repaso.nrojlla.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        public int mostrarMenu()
        {
            int opcionIntroducida;

            Console.WriteLine("#############################");
            Console.WriteLine("###### Menu Cliente ######");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Registro");
            Console.WriteLine("2. Iniciar sesion");
            Console.WriteLine("#############################");
            Console.WriteLine("###### Menu Empleado ######");
            Console.WriteLine("3. Validar registro: ");
            Console.WriteLine("4. Mostrar registros: ");
            Console.WriteLine("5. Borrar registro: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
