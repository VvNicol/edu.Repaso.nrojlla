using edu.repaso.nrojlla.Dto;
using edu.repaso.nrojlla.Servicios;

namespace edu.repaso.nrojlla.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDtos> clienteDtos = new List<ClienteDtos>();

            OperativaInterface oi = new OperativaImplementacion();
            MenuInterface mi = new MenuImplementacion();

            bool esCerrado = false;
            int opcionSeleccionada;

            do
            {
                 opcionSeleccionada = mi.mostrarMenu();

                switch (opcionSeleccionada)
                {

                    case 0:
                        Console.WriteLine("######################");
                        Console.WriteLine("La aplicacion se cerro");
                        esCerrado = true;
                        break;
                    case 1:
                        oi.registroCliente(clienteDtos);

                        break;
                    case 2:
                        oi.iniciarSesion(clienteDtos);

                        break;

                }

            

            } while (!esCerrado);

        }
    }
}