

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        public string? nome;

        public int idade;

        public string? cpf;

        public float Peso { get; set; }

        public float Altura { get; set; }
        


        public void Envelhecer()
        {
            idade++;
        }

        public void Engordar(float _kg)
        {
            Peso = Peso + _kg;
        }
        public void Emagrecer(float _kg)
        {
            Peso = Peso - _kg;
        }





    }
}