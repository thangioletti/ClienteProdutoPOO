using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Menu
    {
        public static ProdutoModel ProdutoModel = new ProdutoModel();
        public static ClienteModel ClienteModel = new ClienteModel();
        private static string MenuPrincipal()
        {
            Console.WriteLine("1 - Produtos");
            Console.WriteLine("2 - Clientes");
            return Console.ReadLine();
        }

        private static string MenuCrud()
        {
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Retornar");
            return Console.ReadLine();
        }

        public static void MostrarMenuPrincipal()
        {
            Console.Clear();
            switch (MenuPrincipal())
            {
                case "1":
                    MostrarMenuProduto();
                    break;
                case "2":
                    MostrarMenuCliente();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

        public static void MostrarMenuProduto(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Produtos");
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (MenuCrud())
            {
                case "1":
                    ProdutoModel.Create();
                    MostrarMenuProduto("Produto adicionado com sucesso!");
                    break;
                case "2":
                    ProdutoModel.Read();
                    Console.WriteLine("Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuProduto();
                    break;
                case "3":
                    ProdutoModel.Update();
                    MostrarMenuProduto("Produto alterado com sucesso!");
                    break;
                case "4":
                    ProdutoModel.Delete();
                    MostrarMenuProduto("Produto removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

        public static void MostrarMenuCliente(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Clientes");
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (MenuCrud())
            {
                case "1":
                    ClienteModel.Create();
                    MostrarMenuCliente("Cliente adicionado com sucesso!");
                    break;
                case "2":
                    ClienteModel.Read();
                    Console.WriteLine("Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuCliente();
                    break;
                case "3":
                    ClienteModel.Update();
                    MostrarMenuCliente("Cliente alterado com sucesso!");
                    break;
                case "4":
                    ClienteModel.Delete();
                    MostrarMenuCliente("Cliente removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

    }
}
