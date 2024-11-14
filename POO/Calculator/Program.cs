using Calculator.Classes;

Console.Clear();
Console.WriteLine($"Bem Vindo ao Calculator");
Console.WriteLine();

Calculadora calculadora = new Calculadora();


Console.Write($"Informe o primeiro numero:");
calculadora.numero1 = float.Parse(Console.ReadLine());

Console.Write($"Informe o segundo numero:");
calculadora.numero2 = float.Parse(Console.ReadLine());

Console.WriteLine(@$"
Escolha uma operaçao:
1) Somar
2) Dividir
3) Multiplicar
4) Subtrair
Opção:");
int operaçao = int.Parse(Console.ReadLine());


if (operaçao == 1)
{
    Console.Write("O resultado eh:");
    calculadora.Somar(0);
}
else if (operaçao == 2)
{
    Console.Write("O resultado eh:");
    calculadora.Dividir(0);
}
else if (operaçao == 3)
{
    Console.Write("O resultado eh:");
    calculadora.Multiplicar(0);

}
else
{
    Console.Write("O resultado eh:");
    calculadora.Subtrair(0);

};


