Console.WriteLine("Digite sua senha:");
int senhaD = int.Parse (Console.ReadLine());

int senha = 1234;

if (senhaD == senha)
{
    Console.WriteLine($"ACESSO PERMITIDO");
}
else 
{
    Console.WriteLine($"ACESSO NEGADO");
}