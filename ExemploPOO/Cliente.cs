using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string EMail { get; set; }

        public void Popular()
        {
            Console.WriteLine("Digite o nome do cliente");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o cpf do cliente");
            CPF = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do cliente");
            EMail = Console.ReadLine();            
        }

        public void Listar()
        {
            Console.WriteLine($" {Nome} | {CPF} | {EMail} ");
        }
    }
}
