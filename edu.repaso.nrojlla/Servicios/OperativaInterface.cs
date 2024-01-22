using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.repaso.nrojlla.Servicios
{
    internal interface OperativaInterface
    {
        void registroCliente(List<Dto.ClienteDtos> clienteDtos);
    }
}
