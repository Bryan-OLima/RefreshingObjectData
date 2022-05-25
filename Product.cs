using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex032
{    
    class Cliente
    {
        private string _nome;
        private int _numeroConta;
        public double Saldo { get; private set; }

        public Cliente()
        {

        }

        public Cliente(int numeroConta, string nome)
        {
            _numeroConta = numeroConta;
            _nome = nome;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Nome inválido");
                }
            }
        }

        //funçao para add numero a conta
        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }
        }

        public int AddConta(int valor)
        {

            if (valor >= 0)
            {
                _numeroConta = valor;
                return _numeroConta;
            }
            else
            {
                Console.WriteLine("Numero inválido");
                return 0;
            }

        }
        //funções para mexer no valor da conta
        public void AddSaldo(double valor)
        {
            Saldo += valor;
        }

        public void SacarSaldo(double valor)
        {
            if ((Saldo - valor) >= 0 && Saldo > 0)
            {
                Saldo = (Saldo - valor) - 5;
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
        }

        public override string ToString()
        {
            return
                "Conta: "
                + _numeroConta
                + " Titular: "
                + _nome
                + " Saldo Atual: R$ "
                + Saldo.ToString("F2");
        }
    }
}
