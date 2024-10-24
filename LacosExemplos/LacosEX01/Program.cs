Console.WriteLine(@"
+-----------------------------+
|    Bem vindo ao programa    |
|     Contador de Pessoas     |
+-----------------------------+
");


int homem = 0;
int mulher = 0;
int qtGostaDeEsportes = 0;
int qtNaoGostaDeEsportes = 0;
string sexo;


Console.WriteLine("Quantas pessoas tem na sua mesa?");
int qtEntrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= qtEntrevistados; i++)
{
    Console.WriteLine($"Qual o seu sexo? ");
    sexo = Console.ReadLine()!;

    if(sexo == "feminino"){
        mulher++;
    }else{
        homem++;
    }

    Console.WriteLine("Voce gosta de esportes? sim/não");
    string esporte = Console.ReadLine()!;

    if(esporte == "sim")
    {
        qtGostaDeEsportes ++;

    }else{
          qtNaoGostaDeEsportes ++;
    }
    
}


float percentual = (100/qtEntrevistados) * qtGostaDeEsportes ; 



Console.WriteLine($"Quantidade de homem: {homem}");
Console.WriteLine($"Quantidade de mulher: {mulher}");
Console.WriteLine($"Total de entrevistados: {mulher + homem}");
Console.WriteLine($"Total de pessoas que gostam de esporte: {qtGostaDeEsportes}");
Console.WriteLine($"Total de pessoas que não gostam de esporte: {qtNaoGostaDeEsportes}");
Console.WriteLine($"Total de percentual de pessoas que gostam de esporte: {percentual} %");

