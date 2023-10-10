using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Estagiario : Funcionario
    {
        public override double CalcularSalarioLiquido()
        {
            return this.Salario * 0.95;
        }
    }
}
