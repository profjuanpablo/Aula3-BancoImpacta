using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoImpacta
{
    internal class Conta
    {
        public int NConta;
        public string? Titular;
        public decimal Saldo;


        public Conta(int nconta)
        {
            this.NConta = nconta;
        }

        //Garbage COllector
        //~Conta() {
        //    Console.WriteLine("Objeto Finalizado");
        //}

        public Conta(int nconta, string titular)
        {
            this.NConta = nconta;
            this.Titular = titular;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Número da conta: {NConta}\n Saldo: {Saldo}");
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            else
            {
                Saldo = Saldo - valor;
            }


        }

        public void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;

        }

        public void Transferir(Conta destino, decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente \n Transferência não Realizada");
            }
            else
            {
                Saldo = Saldo - valor;
                destino.Saldo = destino.Saldo + valor;
            }

        }


    }
}
