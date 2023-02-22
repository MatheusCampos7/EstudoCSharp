using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoCSharp.Titular;

namespace EstudoCSharp.Contas
{
    public class ContaCorrente
    {
        public static int TotalContaCriadas { get; private set; }
        public static float TaxaOperacao { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set {
                 
                    if (value > 0)
                    {
                        this.numeroAgencia = value;
                    } 
                 
                }
        }
        public string Conta{ get; set; }    
        
        private double saldo = 100;
        public Cliente Titular { get; set; }

        public void setSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para a operação!");    
            }

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + this.Titular.Nome);
            Console.WriteLine("CPF: " + this.Titular.Cpf);
            Console.WriteLine("Profissão: " + this.Titular.Profissao);
            Console.WriteLine("Conta: " + this.Conta);
            Console.WriteLine("Número Agência: " + this.numeroAgencia);
            Console.WriteLine("Saldo: " + this.saldo);
        }

        public ContaCorrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a 0.", nameof(numeroAgencia));
    
            }
    
    //        TaxaOperacao = 30/ TotalContaCriadas;

            // try
            // {
            //     TaxaOperacao = 30/ TotalContaCriadas;
            // }
            // catch (System.DivideByZeroException)
            // {
            //    System.Console.WriteLine("Ocorreu um erro! Não é possível fazer uma divisão por 0."); 
            // }

            TotalContaCriadas++;
        }

        //public ContaCorrente(){}


    }

}