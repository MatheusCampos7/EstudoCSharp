using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoCSharp.SistemaInterno;

namespace EstudoCSharp.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
     
        public override double getBonificacao()
        {
            return this.Salario * 0.3;
        }

        public Diretor(string cpf):base(cpf, 5000)
        {
            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }


}