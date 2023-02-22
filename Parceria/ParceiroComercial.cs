using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoCSharp.SistemaInterno;

namespace EstudoCSharp.Parceria
{
    public class ParceiroComercial: IAutenticavel
    {
        public string  Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}