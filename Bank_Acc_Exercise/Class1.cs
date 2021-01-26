
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Exercicio0
{
    class Conta
    {
        public int _contabanco;
        public double Saldo;
        public string Titular;

        public Conta(double saldo) 
        {
            Saldo = saldo;
        }
        public Conta(string titular, int número)
        {
            _contabanco = número;
            Titular = titular;
        }

        public Conta(string titular, int número, double saldo)
        {
            _contabanco = número;
            Titular = titular;
            Saldo = saldo;
        } 
    }
}
