using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1;

        public float numero2;

        public void Somar(float num)
        {
            num = numero1 + numero2;
            Console.WriteLine(num);
            
        }

        public void Subtrair(float num)
        {
            num = numero1 - numero2;
            Console.WriteLine(num);
        }

        public void Multiplicar(float num)
        {
            num = numero1 * numero2;
            Console.WriteLine(num);
        }

        public void Dividir(float num)
        {
            num = numero1 / numero2;
            Console.WriteLine(num);
        }





    }

}