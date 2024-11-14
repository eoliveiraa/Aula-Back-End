using PilaresPOO.Classes.Aprendizagem;

// Aluno julia = new Aluno ();

// julia.nome = "julia";

// Console.WriteLine($"{julia.nome} Nasceu com {julia.idade} anos");


// Aluno claraCras = new Aluno ();
// claraCras.nome = "Clara crass";
// claraCras.matricula = 165467;
// claraCras.curso = "Dev";
// claraCras.media = 7.9f;
// claraCras.idade = 20;
// claraCras.cpf = "235677";
// claraCras.Peso = 39;
// claraCras.Altura = 1.53f;


// Professor sam = new Professor(12445);
// sam.nome = "Samanta";
// sam.idade = 22;
 
// Console.WriteLine($"Curso: {claraCras.curso}");
// Console.WriteLine($"Professor: {sam.nome}");
// Console.WriteLine($"NIF: {sam.NIF}");
// Console.WriteLine($"Idade: {sam.idade}");
// Console.WriteLine();


// Console.WriteLine($"Aluno: {claraCras.nome}");
// Console.WriteLine($"Matricula: {claraCras.matricula}");
// Console.WriteLine($"Media: {claraCras.media}");

// Console.WriteLine($"Cpf: {claraCras.cpf}");
// Console.WriteLine($"idade: {claraCras.idade}");

// Console.WriteLine($"Peso: {claraCras.Peso}");
// Console.WriteLine($"Altura: {claraCras.Altura}");


Carro Carro01 = new Carro ();

Carro01.marca = "Fiat";
Carro01.modelo = "fiat uno";
Carro01.cor = "preto";
Carro01.potencia = "720cv";
Carro01.qtdpassageiro = 7;
Carro01.qtdPortas = 6;


Moto moto01 = new Moto();

moto01.marca = "Yamaha";
moto01.modelo = "xj6";
moto01.cor = "Preto";
moto01.potencia = "371cv";
moto01.qtdpassageiro = 2;


Aviao aviaozinho = new Aviao();

aviaozinho.marca = "latam";
aviaozinho.modelo = "boeing251";
aviaozinho.cor = "Amarelo neon";
aviaozinho.potencia = "165000cv";
aviaozinho.qtdPortas = 2;
aviaozinho.qtdpassageiro = 529;
Console.WriteLine();



Console.WriteLine($"Marca do Carro: {Carro01.marca}");
Console.WriteLine($"Modelo do Carro: {Carro01.modelo}");
Console.WriteLine($"Cor do Carro: {Carro01.cor}");
Console.WriteLine($"Potencia em (Cavalos) do Carro: {Carro01.potencia}");
Console.WriteLine($"Quantidade de Portas: {Carro01.qtdPortas}");
Console.WriteLine($"Quantidade de Portas: {Carro01.qtdpassageiro}");
Carro01.Ligar();
Carro01.Buzinar();
Carro01.Desligar();
Console.WriteLine();




Console.WriteLine($"Marca da moto: {moto01.marca}");
Console.WriteLine($"Modelo da moto: {moto01.modelo}");
Console.WriteLine($"Cor da moto: {moto01.cor}");
Console.WriteLine($"Potencia em (Cavalos) da moto: {moto01.potencia}");
Console.WriteLine($"Quantidade de Portas: {moto01.qtdpassageiro}");
moto01.Ligar();
moto01.Buzinar();
moto01.Desligar();
Console.WriteLine();



Console.WriteLine($"Marca do Aviaozinho: {aviaozinho.marca}");
Console.WriteLine($"Modelo do Aviaozinho: {aviaozinho.modelo}");
Console.WriteLine($"Cor do Aviaozinho: {aviaozinho.cor}");
Console.WriteLine($"Potencia em (Cavalos) do Aviaozinho: {aviaozinho.potencia}");
Console.WriteLine($"Quantidade de Portas: {aviaozinho.qtdPortas}");
Console.WriteLine($"Quantidade de Portas: {aviaozinho.qtdpassageiro}");
aviaozinho.Ligar();
aviaozinho.Desligar();





