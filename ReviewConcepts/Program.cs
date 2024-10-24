// variaveis e tipos de dados

//string nome = "Emilly";
//string sobrenome = "Oliveira";


Console.WriteLine(@"
+-----------------------------+
|  OLA,SEJA BEM-VINDO :)      |
+-----------------------------+
|  Digite seus dados a baixo  |
+-----------------------------+");


Console.WriteLine($" digite seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"ola {nome}, Agora digite seu Sobrenome:");
string sobrenome = Console.ReadLine()!;


//clw
//Console.WriteLine($"Ola seu nome eh: {nome} {sobrenome}");


Console.WriteLine($"Informe seu ano de nascimento:");
int anoNascimento = int.Parse(Console.ReadLine ()!);// 20/12/
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;


Console.WriteLine($"Informe seu E-mail:");
string email = Console.ReadLine()!;

Console.WriteLine($"Informe seu Telefone:");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe seu cpf:");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe seu endereço:");
string endereço = Console.ReadLine()!;

//Console.WriteLine($"Informe sua idade:");
//uint idade = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"Voce eh casado sim ou não?:");
string estadoCivil = Console.ReadLine()!; 


Console.WriteLine($@"
Obrigada, esses são seus dados :)
Nome: {nome} 
Sobrenome: {sobrenome}
Idade: {idade}
E-mail: {email} 
Telefone: {telefone}
Cpf: {cpf} 
Endereço: {endereço} 
Idade: {idade} 
casado(a): {estadoCivil}");



// estruturas condicionais
// laços de repetiçao
// arrays

