using System;
using System.Collections.Generic;
using BibliotecaCoisasBancarias;

namespace minhaAplicacaoBancaria
{
    class Programa
    {
        static void Main(string[] args)
        {
            var conta = new ContaBancaria("Isaias", 25000);
            Console.WriteLine($"Conta bancária de número {conta.Numero} criada para {conta.Proprietario} com saldo de {conta.Saldo} reais.");
            
            conta.RealizarSaque(200, DateTime.Now, "Saque em terminal AA de Alegre.");
            conta.RealizarDeposito(2785, DateTime.Now, "Depósito em terminal AA de Ibatiba");

            Console.WriteLine(conta.GetHistoricoDeTransacoes());
        }
    }
}