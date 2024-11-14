
namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {
        public string? modelo;

        public string? marca;

        public string? cor;

        public string? potencia;

        public int qtdpassageiro;


        public void Ligar()
        {
            Console.WriteLine($"Veiculo ligado");

        }
        public void Buzinar()
        {
            Console.WriteLine($"Veiculo buzinou");

        }
        public void Desligar()
        {
            Console.WriteLine($"Veiculo desligado");

        }

    }
}