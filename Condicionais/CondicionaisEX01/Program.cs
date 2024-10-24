

Console.WriteLine("Infome seu salario recebido");
float salario = float.Parse (Console.ReadLine()!);

Console.WriteLine("Infome seu total de gastos");
float gastos = float.Parse (Console.ReadLine()!);

if (salario > gastos) 
{
Console.WriteLine("Gastos dentro do orçamento :)");

} else 
{Console.WriteLine("Orçamento estourado :(")}
