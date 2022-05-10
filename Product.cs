using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex032
{    
    class Product
    {
        private double taxa = 5.0;

        private double _saldo;
        public int Conta { get; private set; } 
        public string Nome { get; private set; }

        public int AdicionarConta(int conta)
        {
            return Conta = conta;
        }

        public void AdicionarNome(string nome)
        {
            Nome = nome;
        }

        public void DepositarValor(double valor)
        {       
            _saldo += valor;
        }

        public void SacarValor(double valor)
        { 
            _saldo = (_saldo - valor) - taxa;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", Títular: "
                + Nome
                + ", Saldo: "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
