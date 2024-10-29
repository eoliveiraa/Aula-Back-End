int[] arraysNumero1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int[] arraysNumero2 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };



for (int i = 0; i < arraysNumero1.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(arraysNumero1[i]);

    }
    else
    {

        Console.WriteLine(arraysNumero2[i]);

    }

}