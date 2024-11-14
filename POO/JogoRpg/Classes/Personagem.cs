
namespace JogoRpg.Classes
{
    public class Personagem
    {

        public String? Nome;

        public int? Idade;

        public string? Armadura;


        public string? IA;


        public void Atacar()
        {
            Console.WriteLine($"O  {Nome} atacou 🥷🎇");
        }

        public void Defender()
        {
            Console.WriteLine($"O(a) {Nome} defendeu 🎯🩻");
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O(a) {Nome} restaurou sua armadura 🥋🛡️");
        }





    }
}

