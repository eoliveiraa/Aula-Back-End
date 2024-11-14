using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string? nome { get; set; }
        public float? lançamento { get; set; }
        public string? genero { get; set; }
        public float? preço { get; set; }


        public Jogo(string NM, int Lm, String Gn, float Pç)
        {
            nome = NM;
            lançamento = Lm;
            genero = Gn;
            preço = Pç;
        }


        public void ExibirDados()
        {

            Console.WriteLine($@"
            Nome:{nome}
            Lançamento:{lançamento}
            Genero:{genero}
            Preço:{preço}
            ");




        }















    }
}