using edu.repaso.nrojlla.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.repaso.nrojlla.Servicios
{
    internal class OperativaImplementacion : OperativaInterface
    {       

        public void registroCliente(List<ClienteDtos> clienteDtos)
        {
            clienteDtos.Add(crearNuevoRegistroCliente(clienteDtos));
        }
        private ClienteDtos crearNuevoRegistroCliente(List<ClienteDtos> clienteDtos)
        {
            ClienteDtos clienteDto = new ClienteDtos();
            
            Console.WriteLine("Introduzca el DNI: ");
            clienteDto.DniCliente = Console.ReadLine();
            
            Console.WriteLine("Introduzca el nombre comleto: ");
            clienteDto.NombreCompletoCliente = Console.ReadLine();

            Console.WriteLine("Crear email: ");
            clienteDto.EmailCliente = Console.ReadLine();

            Console.WriteLine("Crear contraseña: ");
            clienteDto.ContraseniaCliente = Console.ReadLine();

            clienteDto.EsValidado = false;
            
            Console.WriteLine(clienteDto.IdCliente = generarIdCliente(clienteDtos));

            
            return clienteDto;
        }

        private long generarIdCliente(List<ClienteDtos> clienteDtos)
        {
            if (clienteDtos.Count > 0)
            {
                ClienteDtos ultimoCliente = clienteDtos[clienteDtos.Count - 1];
                long nuevoIdCliente = ultimoCliente.IdCliente + 1;

                return nuevoIdCliente;
            } else
            {
               return 1;
            }
            
        }

    }
}
