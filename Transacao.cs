using System;

namespace meuAppDotNET
{
    public class Transacao
    {
        public decimal Valor { get; }
        public DateTime Data { get; }
        public string Descricao { get; }

        public Transacao(decimal valor, DateTime data, string descricao){
            this.Valor = valor;
            this.Data = data;
            this.Descricao = descricao;
        }
    }
}