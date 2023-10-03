using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Login
    {
        public static string Usuario { get; set; }
        public static string Password { get; set; }

        public static void Logar()
        {
            Console.WriteLine("Digite o usuario");
            Usuario = Console.ReadLine();

            Console.WriteLine("Digite a senha");
            Password = Console.ReadLine();

            if (Usuario == "tiago" && Password == "123") {
                Menu.MostrarMenuPrincipal();
            } else
            {
                Console.WriteLine("Login invalido");
                Logar();
            }
        }

    }
}
