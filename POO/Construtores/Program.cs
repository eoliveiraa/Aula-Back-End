using Construtores.Classes;

// Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Preto");
// Veiculo carro2 = new Veiculo("Ford", "Mustang", 2007, "Roxo");

// carro1.ExibirDados();
// carro2.ExibirDados();

// Aluno al1 = new Aluno ("Marquinhas", 20, 1);
// Aluno al2 = new Aluno ("Marquinhos", 21, 1);

// al1.ExibirDados();
// al2.ExibirDados();


// Jogo JG2 = new Jogo ("DressCode",5644,"Moda",80);
// Jogo JG3 = new Jogo ("Fogo&Agua",2044,"Aventura",80);
// Jogo JG4 = new Jogo ("Valorant",2019,"Ação",80);

// estoqueJogos.Add(JG);
// estoqueJogos.Add(JG2);
// estoqueJogos.Add(JG3);
// estoqueJogos.Add(JG4);

// JG.ExibirDados();
// JG2.ExibirDados();

// Jogo JG = new Jogo(NM, Lm, Gn,);

// List<Jogo> estoqueJogos = new List<Jogo>();
// int opcao;

// do
// {
//     Console.WriteLine($@"
// Escolha uma opcao:
// 1) Cadastrar Jogo
// 2) Listar Jogos
// 0) Sair");
// opcao = int.Parse(Console.ReadLine()!);

//     if (opcao == 1)
//     {
//         Console.WriteLine($"Informe o nome do jogo:");
//         string nome = Console.ReadLine()!;
      


//     }
//     else if (opcao == 2)
//     {

//         foreach (var Jogo in estoqueJogos)
//         {
//             Console.WriteLine($"Jogo: {Jogo.nome} 🎮");

        
//     }
// }
// }while (opcao == 0);

//     Console.WriteLine($"Voce escolheu sair 😮 ");



Aluno2 annaCarolina = new Aluno2("Anna Carolina", 76578);
 annaCarolina.cpf =33342;

Aluno2 marquinhos = new Aluno2("Marquinhos",26789);
 marquinhos.cpf =33342;

Aluno2 eduCosta = new Aluno2 ("Edu Costa", 24572);
 eduCosta.cpf =33342;


Console.WriteLine(annaCarolina.nome);
Console.WriteLine(annaCarolina.cpf);

Console.WriteLine(marquinhos.nome);
Console.WriteLine(marquinhos.cpf);

Console.WriteLine(eduCosta.nome);
Console.WriteLine(eduCosta.cpf);
