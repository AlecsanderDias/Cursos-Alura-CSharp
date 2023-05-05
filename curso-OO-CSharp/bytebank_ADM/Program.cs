using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario alec = new Funcionario("123",1000);
//alec.Nome = "Alec Dias";

//Console.WriteLine(alec.Nome);
//Console.WriteLine(alec.CPF);
//Console.WriteLine(alec.Salario);
//Console.WriteLine(alec.GetBonificacao());

//Diretor pedro = new Diretor("1234");
//pedro.Nome = "Pedro Hernandes";

//GerenciadorDeBonificacao bonificacao = new GerenciadorDeBonificacao();
//bonificacao.Registrar(alec);
//Console.WriteLine(bonificacao.TotalBonificacao);
//bonificacao.Registrar(pedro);
//Console.WriteLine(bonificacao.TotalBonificacao);

//Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

//alec.AumentarSalario();
//pedro.AumentarSalario();

//Console.WriteLine("Novo salário do Alec: " + alec.Salario);
//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Auxiliar jorge = new Auxiliar("222222");
    jorge.Nome = "Jorge Henrique";

    Designer ana = new Designer("3333333");
    ana.Nome = "Ana Clara";

    Diretor pedro = new Diretor("444444");
    pedro.Nome = "Pedro Hernandes";

    GerenteDeConta alec = new GerenteDeConta("11111111");
    alec.Nome = "Alec Dias";

    gerenciador.Registrar(alec);
    gerenciador.Registrar(pedro);
    gerenciador.Registrar(ana);
    gerenciador.Registrar(jorge);

    Console.WriteLine($"Total de Bonificação {gerenciador.TotalBonificacao}");
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("852741");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeConta ursula = new GerenteDeConta("963741");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    ParceiroComercial jorge = new ParceiroComercial();
    jorge.Senha = "222";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
    sistema.Logar(jorge, "222");

}