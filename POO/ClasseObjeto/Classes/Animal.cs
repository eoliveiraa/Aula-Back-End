using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseObjeto.Classes
{
    public class Animal
    {
        public string raca;
        public string cor;
        public string nome;
        public float  idade = 0;

        public void FazerBarulho(string barulho)
        {
            Console.WriteLine($"Som de um animal: {barulho}");
        }


        public void Envelhecer()
        {
            idade = idade + 1;
        }

    }
}