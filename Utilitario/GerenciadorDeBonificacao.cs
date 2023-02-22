using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoCSharp.Funcionarios;

namespace EstudoCSharp.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
                
            this.TotalDeBonificacao += funcionario.getBonificacao();    
            
        }  
    }
}