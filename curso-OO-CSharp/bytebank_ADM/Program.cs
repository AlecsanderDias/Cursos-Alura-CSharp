using bytebank_ADM.Funcionarios;

Funcionario alec = new Funcionario();
alec.Nome = "Alex Dias";
alec.Salario = 1500;
alec.CPF = "123";
Console.WriteLine(alec.Nome);
Console.WriteLine(alec.CPF);
Console.WriteLine(alec.Salario);
Console.WriteLine(alec.GetBonificacao());