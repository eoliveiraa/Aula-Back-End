Console.WriteLine(@"
+------------------------------+
|      BEM-VINDO AO PROGRAMA   | 
|         Media Aluno          |
+------------------------------+ ");




Console.WriteLine("informe a sua nota");
float nota = float.Parse(Console.ReadLine());

Console.WriteLine("informe a sua frequencia");
float frequencia = float.Parse(Console.ReadLine());

if (nota >= 7.0 && frequencia >= 75 ){
Console.WriteLine("Voce foi APROVADO :)");
}
else if (nota <= 7 && frequencia < 75){
Console.WriteLine("Voce esta REPROVADO :(");
}
else {
    Console.WriteLine("Voce esta de RECUPERAÇAO");
}