using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class ClienteModel : ICrud
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void Create()
        {
            Cliente cliente = new Cliente();
            cliente.Popular();
            clientes.Add(cliente);
        }

        public void Read()
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.Write(i);
                clientes[i].Listar();
            }
        }

        public void Update()
        {
            Read();
            Console.WriteLine("Digite o codigo do item a ser alterado:");
            int index = Convert.ToInt32(Console.ReadLine());
            clientes[index].Popular();
        }

        public void Delete()
        {
            Read();
            Console.WriteLine("Digite o codigo do item a ser alterado:");
            int index = Convert.ToInt32(Console.ReadLine());
            clientes.RemoveAt(index);
        }
    }
}
