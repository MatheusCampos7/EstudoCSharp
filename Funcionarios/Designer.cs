using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoCSharp.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }        
    }
}