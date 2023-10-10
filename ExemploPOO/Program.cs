namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Login.Logar();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Tiago";
            funcionario.Salario = 1000;

            Estagiario estagiario = new Estagiario()
            {
                Nome = "Joao",
                Salario = 500,
            };

            Gerente gerente = new Gerente()
            {
                Nome = "Cleber",
                Salario = 10000,
            };

            //Console.WriteLine($"O Funcionario {funcionario.Nome} ganha liquido: R${funcionario.CalcularSalarioLiquido()}");
            //Console.WriteLine($"O Estagiario {estagiario.Nome} ganha liquido: R${estagiario.CalcularSalarioLiquido()}");
            //Console.WriteLine($"O Gerente {gerente.Nome} ganha liquido: R${gerente.CalcularSalarioLiquido()}");

            Console.WriteLine($"2+2={Calculadora.Somar(2, 2)}");
            Console.WriteLine($"2.5+2.5={Calculadora.Somar(2.5, 2.5)}");
        }

        public void Demonstrar(ICrud model)
        {

        }
    }
}