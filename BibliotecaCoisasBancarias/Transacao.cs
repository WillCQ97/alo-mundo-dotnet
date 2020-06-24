using System;
using Humanizer;

namespace BibliotecaCoisasBancarias
{
    public class Transacao
    {
        public decimal Valor { get; }
        public string ValorParaHumanos { 
            get {
               return ((int)Valor).ToWords();
            }
        }
        public DateTime Data { get; }
        public string Descricao { get; }

        public Transacao(decimal valor, DateTime data, string descricao){
            this.Valor = valor;
            this.Data = data;
            this.Descricao = descricao;
        }
    }
}