using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoCSharp.Funcionarios;
using EstudoCSharp.Parceria;

namespace EstudoCSharp.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Usuário autenticado.");
                return true;
            }  
            else
            {
                System.Console.WriteLine("Senha incorreta.");
                return false;

            } 
        }     
      
    }
}