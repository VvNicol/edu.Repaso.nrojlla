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
            Console.WriteLine("--------------------");
            Console.WriteLine("Introduzca el DNI: ");
            clienteDto.DniCliente = Console.ReadLine();
            
            Console.WriteLine("Introduzca el nombre completo: ");
            clienteDto.NombreCompletoCliente = Console.ReadLine();
            separarNombreCliente(clienteDto);
            

            Console.WriteLine("Crear email: ");
            clienteDto.EmailCliente = Console.ReadLine();

            Console.WriteLine("Crear contraseña: ");
            clienteDto.ContraseniaCliente = Console.ReadLine();

            clienteDto.EsValidado = false;
            
            clienteDto.IdCliente = generarIdCliente(clienteDtos);

            return clienteDto;
        }

        private long generarIdCliente(List<ClienteDtos> clienteDtos)
        {
            if (clienteDtos.Count > 0)
            {
                ClienteDtos ultimoCliente = clienteDtos[clienteDtos.Count - 1];
                long nuevoIdCliente = ultimoCliente.IdCliente + 1;

                return nuevoIdCliente;

            }
            else
            {
               return 1;
            }            
        }

        private void separarNombreCliente(ClienteDtos clienteDto)
        {           
            string[] textoSeparado = clienteDto.NombreCompletoCliente.Split(' ');
            if(textoSeparado.Length >= 3)
            {
                clienteDto.NombreCliente = textoSeparado[0];
                clienteDto.Apellido1Cliente = textoSeparado[1];
                clienteDto.Apellido2Cliente = textoSeparado[2];                
            }
        }

        public void iniciarSesion(List<ClienteDtos> clienteDtos)
        {
            ClienteDtos clienteDto = new ClienteDtos();

           

            Console.WriteLine("--------------------");
            Console.WriteLine("Introduzca email: ");
            string emailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca contrasena: ");
            string contrasenaCliente = Console.ReadLine();


            //var mayores = clienteDto.EmailCliente.Where(num => num == emailCliente);

            if (emailCliente.Equals(clienteDto.EmailCliente) && contrasenaCliente.Equals(clienteDto.ContraseniaCliente))
            {
                Console.WriteLine(" email correcto");
            }else
            {
                Console.WriteLine("ocurrio un fallo");
            }
        }
    }
}
