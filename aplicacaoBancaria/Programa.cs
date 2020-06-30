using BibliotecaCoisasBancarias;
using System;
using System.Text;

namespace aplicacaoBancaria
{
    class Programa
    {
        static void Main(string[] args)
        {
            var dados = new DadosBancarios();
            var contas = dados.Contas;

            var builder = new StringBuilder();
            builder.AppendLine("-----------------------------------");
            builder.AppendLine("--- Bem-vindo ao BANCO DA PRAÇA ---");
            builder.AppendLine("-----------------------------------");
            builder.AppendLine("-- Opções Disponíveis --");
            builder.AppendLine("--");
            builder.AppendLine("1 - Listar contas cadastradas.");
            builder.AppendLine("2 - Cadastrar uma nova conta.");
            builder.AppendLine("3 - Exibir dados de uma conta.");
            builder.AppendLine("4 - Exibir transações de uma conta.");
            builder.AppendLine("5 - Encerrar uma conta.");
            builder.AppendLine("0 - SAIR DO PROGRAMA.");
            builder.AppendLine("--");

            var resp = -1;
            try
            {
                while (resp != 0)
                {
                    Console.Write(builder.ToString());

                    Console.Write("Em que posso ajudá-lo hoje? ");
                    resp = System.Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Opção selecionada: " + resp + "\n--");
                    
                    switch (resp)
                    {
                        case 0:
                            Console.WriteLine("Saindo... Até mais!");
                            break;

                        case 1:
                            Console.WriteLine("Listando contas ...");
                            Console.WriteLine(dados.GerarListagemDeContas());
                            break;

                        case 2:
                            Console.WriteLine("Criação de contas selecionada.");
                            Console.WriteLine("Informe os dados: ");

                            Console.Write("Nome: ");
                            var nome = Console.ReadLine();
                            Console.Write("Saldo: ");
                            var saldo = Decimal.Parse(Console.ReadLine());

                            dados.AddContaBancaria(new ContaBancaria(nome, saldo));
                            break;

                        case 3:
                            Console.WriteLine("Buscar informação de determinada conta.");
                            Console.Write("Informe o número da conta: ");
                            var numero = Int32.Parse(Console.ReadLine());
                            var conta = dados.GetDadosContaBancaria(numero);

                            if (conta != null)
                            {
                                Console.WriteLine("A conta foi encontrada!");
                                Console.WriteLine(conta.ToString());
                            }
                            else
                            {
                                Console.WriteLine("O número de conta informado não existe.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Exibir transações de uma dada conta.");
                            Console.Write("Informe o número da conta: ");
                            numero = Int32.Parse(Console.ReadLine());
                            conta = dados.GetDadosContaBancaria(numero);

                            if(conta != null){
                                Console.WriteLine("Lista de transações para a conta " + numero);
                                Console.WriteLine(conta.GetHistoricoDeTransacoes());
                            }else{
                                Console.WriteLine("Conta inexistente. Verifique o número informado.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Remover conta cadastrada.");
                            Console.Write("Informe o número da conta: ");
                            numero = Int32.Parse(Console.ReadLine());
                            conta = dados.GetDadosContaBancaria(numero);

                            if (conta != null)
                            {
                                Console.WriteLine(conta.ToString());
                                Console.WriteLine("A conta foi removida.");
                            }
                            else
                            {
                                Console.WriteLine("O número de conta informado não existe.");
                            }
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {   
                Console.WriteLine(e.ToString());
                Console.WriteLine("Erro! Encerrando o programa forçadamente.");
            }
        }
    }
}