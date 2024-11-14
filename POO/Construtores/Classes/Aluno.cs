using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {

        public string? nome { get; set; }

        public int? idade { get; set; }

        public int? matricula { get; set; }


        public Aluno(string Nm, int Id, int mat)
        {
        nome = Nm;
        idade = Id;
        matricula = mat;
        
        }


        public void ExibirDados()
        {
        Console.WriteLine($@"
        Nome: {nome}
        Idade: {idade}
        Matricula:{matricula}");

        }


    }
}