using EstudoCSharp.Contas;
using EstudoCSharp;
using EstudoCSharp.Funcionarios;
using EstudoCSharp.Parceria;
using EstudoCSharp.SistemaInterno;
using EstudoCSharp.Titular;
using EstudoCSharp.Utilitario;

#region 

// ContaCorrente contaDoAndre = new ContaCorrente();
// contaDoAndre.titular = "André Silva";
// contaDoAndre.numeroAgencia = 15;
// contaDoAndre.conta = "1010-X";
// contaDoAndre.saldo = 100;

// contaDoAndre.ExibirDadosDaConta();

// Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

// ContaCorrente contaDaMaria = new ContaCorrente();
// contaDaMaria.titular = "Maria Souza";
// contaDaMaria.numeroAgencia = 17;
// contaDaMaria.conta = "1010-5";
// contaDaMaria.saldo = 350;

// Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

// contaDoAndre.Transferir(50, contaDaMaria);
// System.Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
// System.Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);


// contaDoAndre.Depositar(100);

// Console.WriteLine("Saldo da conta do André pós-deposito = " + contaDoAndre.saldo);

// if (contaDoAndre.Sacar(253))
// {
//     Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
// }
// else
// {
//     Console.WriteLine("Saldo insuficiente");
// }

// Cliente cliente = new Cliente();
// cliente.Nome = "Matheus Campos";
// cliente.Cpf = "09876454777";
// cliente.Profissao = "Software Engineer";

// ContaCorrente conta = new ContaCorrente();
// conta.Titular = cliente;
// conta.Conta = "52246-6";
// conta.NumeroAgencia = 1415;
// conta.setSaldo(8566.54);

// System.Console.WriteLine("Titular = " + conta.Titular.Nome);
// System.Console.WriteLine("CPF = " + conta.Titular.Cpf);
// System.Console.WriteLine("Profissão = " + conta.Titular.Profissao);
// System.Console.WriteLine("Nº Agencia = " + conta.NumeroAgencia);
// System.Console.WriteLine("Nº Conta = " + conta.Conta);
// System.Console.WriteLine("Saldo = " + conta.getSaldo());

// ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
// conta4.setSaldo(500);
// conta4.Titular = new Cliente();

// System.Console.WriteLine(conta4.getSaldo());
// System.Console.WriteLine(conta4.NumeroAgencia);
// System.Console.WriteLine(ContaCorrente.TotalContaCriadas);

// ContaCorrente conta5 = new ContaCorrente(18, "1011-x");
// conta4.setSaldo(201);
// conta4.Titular = new Cliente();
// System.Console.WriteLine(ContaCorrente.TotalContaCriadas);

// ContaCorrente conta6 = new ContaCorrente(18, "1012-x");
// conta4.setSaldo(124);
// conta4.Titular = new Cliente();
// System.Console.WriteLine(ContaCorrente.TotalContaCriadas);


// Funcionario pedro = new Funcionario("987684321-71", 3200);
// pedro.Nome = "Pedro da Silva";
// //pedro.Cpf = "987684321-71";
// //pedro.Salario = 3200;

// Diretor roberta = new Diretor("152455421-71");
// roberta.Nome = "Roberta de Souza";
// //roberta.Cpf = "152455421-71";
// //roberta.Salario = 5000;

// System.Console.WriteLine(pedro.Nome);
// System.Console.WriteLine("Salário: R$ " + Math.Round(pedro.Salario, 2));
// System.Console.WriteLine("Bonificação: R$ " + Math.Round(pedro.getBonificacao(), 2));

// System.Console.WriteLine(roberta.Nome);
// System.Console.WriteLine("Salário: R$ " + Math.Round(roberta.Salario, 2));
// System.Console.WriteLine("Bonificação: R$ " + Math.Round(roberta.getBonificacao(), 2));

// GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(roberta);

// System.Console.WriteLine("Total de bonificação: R$ " + gerenciador.TotalDeBonificacao);
// System.Console.WriteLine("Total de funcionários: " + Funcionario.TotalFuncionarios);

// pedro.AumentarSalario();
// roberta.AumentarSalario();

// System.Console.WriteLine("Novo Salário Pedro: R$ " + Math.Round(pedro.Salario, 2));
// System.Console.WriteLine("Novo Salário Roberta: R$ " + Math.Round(roberta.Salario, 2));

#endregion

//CalculaBonificacao();
// UsarSistema();

// void CalculaBonificacao()
// {
//     GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//     Designer ulisses = new Designer("1326548574");
//     ulisses.Nome = "Ulisses Guimarães";

//     Diretor paula = new Diretor("52413511");
//     paula.Nome = "Paula Tenório";

//     Auxiliar flavio = new Auxiliar("31254855");
//     flavio.Nome = "Flávio Barra";

//     GerenteDeContas alice = new GerenteDeContas("876546575");
//     alice.Nome = "Alice Martins";

//     gerenciador.Registrar(ulisses);
//     gerenciador.Registrar(paula);
//     gerenciador.Registrar(flavio);
//     gerenciador.Registrar(alice);

//     System.Console.WriteLine("Total de Bonificação: R$ " + gerenciador.TotalDeBonificacao );




// }



// void UsarSistema()
// {  
    // SistemaInterno sistema = new SistemaInterno();    

    // Diretor marcos = new Diretor("5213213");
    // marcos.Nome = "Marcos Castro";
    // marcos.Senha = "123";

    // GerenteDeContas sergio = new GerenteDeContas("54653215");
    // sergio.Nome = "Sérgio Lopes";
    // sergio.Senha = "321";

    // Designer adrian = new Designer("5241541581");
    // adrian.Nome = "Adrian Gama";
    // adrian.Senha = "987";

    // Auxiliar joab = new Auxiliar("332125812");
    // joab.Nome = "Joab Lourenço";
    // joab.Senha = "654";

    // sistema.Logar(marcos, "123");
    // sistema.Logar(sergio, "221");
    // sistema.Logar(joab, "555");
    // sistema.Logar(adrian, "987");

    // ParceiroComercial kauan = new ParceiroComercial();
    // kauan.Senha = "564";

    // sistema.Logar(kauan, "564");

// }


// try
// {
//     ContaCorrente conta = new ContaCorrente(0, "1324-x");
//     // conta.Sacar(50);
//     // System.Console.WriteLine(conta.getSaldo());
//     // conta.Sacar(150);


    
// }
// catch (ArgumentException e)
// {
//     System.Console.WriteLine("Parâmetro com erro: " + e.ParamName);
//     System.Console.WriteLine("Não é possível criar uma agência com número menor ou igual a 0.");
//     Console.WriteLine(e.StackTrace);
//     System.Console.WriteLine(e.Message);
    
// }
// catch(SaldoInsuficienteException e)
// {
//     System.Console.WriteLine("Operação negada! Saldo insuficiente!");
//     System.Console.WriteLine(e.Message);
// }


 LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
 
 try
 {
     leitor.LerProximaLinha();
     leitor.LerProximaLinha();
     
 }
 catch (IOException)
 {
     System.Console.WriteLine("Leitura de arquivo interrompida!");
 }
 finally
 {
     leitor.Fechar();
 }
