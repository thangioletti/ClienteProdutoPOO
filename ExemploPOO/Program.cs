namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Login.Logar();
            
            Funcionario funcionario = new Funcionario();
            funcionario.Salario = 1000;
            funcionario.Nome = "Tiago";

            Estagiario estagiario = new Estagiario()
            {
                Salario = 500,
                Nome = "Joaozinho"
            };

            Gerente gerente = new Gerente()
            {
                Nome = "Cleber",
                Salario = 10000
            };

            Console.WriteLine($"O funcionario {funcionario.Nome} recebe liquido {funcionario.CalcularSalarioLiquido()}");
            Console.WriteLine($"O estagiario {estagiario.Nome} recebe liquido {estagiario.CalcularSalarioLiquido()}");
            Console.WriteLine($"O gerente {gerente.Nome} recebe liquido {gerente.CalcularSalarioLiquido()}");


        }

        public void Demonstrar(ICrud model)
        {

        }
    }
}