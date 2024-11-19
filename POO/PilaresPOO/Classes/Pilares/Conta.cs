

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        protected float Saldo;

        public string? Titular;

        public abstract float Sacar(float valor);

        public abstract bool Depositar(float valor);

        public float getSaldo()
        {
            return Saldo;
        }
    }
}