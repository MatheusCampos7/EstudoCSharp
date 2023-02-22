using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoCSharp.SistemaInterno;

namespace EstudoCSharp.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get ; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}