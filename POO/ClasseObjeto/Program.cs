//Importando as classes dentro da pasta Classes
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using ClasseObjeto.Classes;

//Cria o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Blue";
cachorro.raca = "PitBull";
cachorro.cor = "Cinza";
cachorro.idade = 8;

Console.WriteLine($"Nome da {cachorro.nome}: {cachorro.nome}");
Console.WriteLine($"Raca da {cachorro.nome}: {cachorro.raca}");
Console.WriteLine($"Cor da {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Idade da {cachorro.nome}: {cachorro.idade}");

Console.WriteLine($"");


Animal gato = new Animal();

gato.nome = "Nala";
gato.raca = "vira-lata";
gato.cor = "marrom";
gato.idade = 0.3f;

Console.WriteLine($"Nome do {gato.nome}: {gato.nome}");
Console.WriteLine($"Raca do {gato.nome}: {gato.raca}");
Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");

Console.WriteLine($"");

Animal tigre = new Animal();

tigre.nome = "Ares";
tigre.raca = "Tigre-Branco";
tigre.idade = 3;
tigre.cor = "Branco";


Console.WriteLine($"Nome do {tigre.nome}: {tigre.nome}");
Console.WriteLine($"Raca do {tigre.nome}: {tigre.raca}");
Console.WriteLine($"Cor do {tigre.nome}: {tigre.cor}");
Console.WriteLine($"Idade do {tigre.nome}: {tigre.idade}");

Console.WriteLine($"");

cachorro.FazerBarulho("AuAu");
Console.WriteLine($"idade do {cachorro.nome} eh {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade de {cachorro.nome} eh {cachorro.idade}");

Console.WriteLine($"");

tigre.FazerBarulho("Ruarghhh");
Console.WriteLine($"idade do {tigre.nome} eh {tigre.idade}");
tigre.Envelhecer();
Console.WriteLine($"Nova idade do {tigre.nome} eh {tigre.idade}");
