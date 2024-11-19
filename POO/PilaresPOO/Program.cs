using PilaresPOO.Classes.Pilares;

ContaCorrente ctEmy = new ContaCorrente();
ctEmy.Titular = "Emilly beutiful😼";
ctEmy.Depositar(1000000f) ;


Console.WriteLine($"Titular da conta {ctEmy.Titular}");
Console.WriteLine($"Saldo da conta {ctEmy.getSaldo()}");

float valorSacado = ctEmy.Sacar(7000f);

Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Novo Saldo: {ctEmy.getSaldo()}");



