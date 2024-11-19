

namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite { get; set; }

        public override float Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                return valor;
            }
            else
            {
                Console.WriteLine($"Valor Menor que o saldo");
                
                return 0;
            }



        }

        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool Transferir(float valor, Conta ContaDestino)
        {
            return false;
        }

    }
}