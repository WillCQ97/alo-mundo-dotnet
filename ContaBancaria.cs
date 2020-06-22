using System;
using System.Collections.Generic;
using System.Text;

namespace meuAppDotNET 
{
    public class ContaBancaria 
    {
        public string Numero { get; }
        public string Proprietario { get; set; }
        public decimal Saldo { 
            get{
                decimal saldo = 0;
                foreach(var transacao in transacoes)
                {
                    saldo += transacao.Valor;
                }
                return saldo;
            } 
        }
        private static int sementeNumeroConta = 1234567890;
        private List<Transacao> transacoes = new List<Transacao>();

        public ContaBancaria(string nome, decimal saldoInicial)
        {
            this.Numero = sementeNumeroConta.ToString();
            sementeNumeroConta++;
            this.Proprietario = nome;

            this.RealizarDeposito(saldoInicial, DateTime.Now, "Saldo inicial.");
        }

        public void RealizarDeposito(decimal valor, DateTime data, string descricao)
        {
            if(valor <= 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor do depósito deve ser positivo.");
            }
            
            var deposito = new Transacao(valor, data, descricao);
            transacoes.Add(deposito);
        }

        public void RealizarSaque(decimal valor, DateTime data, string descricao)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque deve ser positivo.");
            }

            if(Saldo - valor < 0) 
            {
                throw new InvalidOperationException("O saldo disponível é insuficiente para este saque.");
            }

            var saque = new Transacao(-valor, data, descricao);
            transacoes.Add(saque);
        }

        public string GetHistoricoDeTransacoes()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Data\t\tValor\tDescrição");
            
            foreach (var item in transacoes)
            {
                builder.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{item.Descricao}");
            }

            return builder.ToString();
        }
    }
}