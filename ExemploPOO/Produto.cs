using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Produto
    {
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public string Time { get; set; }

        public double Preco { get; set; }

        public void Popular()
        {
            Console.WriteLine("Digite o nome do produto");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o codigo de barras do produto");
            CodigoBarras = Console.ReadLine();

            Console.WriteLine("Digite o time do produto");
            Time = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto");
            Preco = Convert.ToDouble(Console.ReadLine());
        }

        public void Listar()
        {
            Console.WriteLine($" {Nome} | {CodigoBarras} | {Time} | {Preco}");
        }
    }
}
