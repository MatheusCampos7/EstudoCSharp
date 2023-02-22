using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoCSharp
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string msg): base(msg)
        {

        }   

        public OperacaoFinanceiraException(string msg, Exception excecaoInterna): base(msg, excecaoInterna)
        {
            
        }
    }
}