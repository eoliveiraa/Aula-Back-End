
namespace PilaresPOO.Classes.Pilares
{
    public class ContaPoupanca : Conta
    {
        public int LimiteSaque { get; set; }

        public float rendimento { get; set; }


        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }

        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

    }
}