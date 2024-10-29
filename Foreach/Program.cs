string[] frutas = {"Morango", "Limao", "Caju", "Manga", "Abacate", "Pitaya", "Jabuticaba", "Kiwi","Pessego", "Banana", "Acerola"};

Console.WriteLine($"Sua sacola contem {frutas.Length} frutas!");

foreach(string f in frutas)
{
    Console.WriteLine($"{f},");
}
