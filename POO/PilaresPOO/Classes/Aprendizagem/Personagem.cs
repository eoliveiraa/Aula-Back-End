
namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Personagem
    {
       public abstract void Atacar();
       

        public virtual void Defender()
        {
            Console.WriteLine("O personagem defendeu!!");
            
        }

    }


}