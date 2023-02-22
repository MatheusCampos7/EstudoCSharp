using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoCSharp.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}