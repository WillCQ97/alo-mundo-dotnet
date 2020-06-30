using BibliotecaCoisasBancarias;
using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacaoBancaria {
    /* Iniciará alguns dados de contas para a aplicação */
    class DadosBancarios {
        public List<ContaBancaria> Contas { get; }
        public DadosBancarios() {
            var nomes = new List<String> {"Isaias", "Maria", "Willian", "Wellignton", "Wuhoschiton", "Araci", "Ariani", "Alcione", "Andréia"};

            this.Contas = new List<ContaBancaria>();

            foreach(var nome in nomes) {
                var saldo = nome.Length * 2;
                var valor = nome.Length;
                var conta = new ContaBancaria(nome, saldo);
                
                conta.RealizarSaque(valor, DateTime.Now, "Saque em terminal AA.");
                conta.RealizarDeposito((decimal) (valor * 1.5), DateTime.Now, "Depósito em terminal AA.");
                
                Contas.Add(conta);
            }
        }

        public string GerarListagemDeContas()
        {   
            var builder = new StringBuilder();
            
            foreach(var conta in Contas){
                builder.AppendLine("- Numero: " + conta.Numero + "\t- Proprietário\t" + conta.Proprietario + "\t-");
            }
            return builder.ToString();
        }

        public void AddContaBancaria(ContaBancaria conta)
        {
            this.Contas.Add(conta);
        }

        public ContaBancaria GetDadosContaBancaria(int numeroConta){
            foreach (var conta in Contas)
            {
                if(conta.Numero == numeroConta.ToString()){
                    return conta;
                }
            }

            return null;
        }

        public void RemoverContaBancaria(int numeroConta)
        {
            foreach(var conta in Contas){
                if(conta.Numero == numeroConta.ToString()){
                    this.Contas.Remove(conta);
                }
            }
        }
    }
}