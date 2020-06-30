using System;
using Xunit;
using BibliotecaCoisasBancarias;

namespace TestesBancarios
{
    public class TestesBasicos
    {
        [Fact]
        public void TesteCriacaoContaSaldoNegativo()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> new ContaBancaria("Conta invalida", -674)
            );
        }

        [Fact]
        public void TesteSaqueValorMaiorQueSaldo()
        {
            var conta = new ContaBancaria("Isaias", 25000);

            Assert.Throws<InvalidOperationException>(
                () => conta.RealizarSaque(50000, DateTime.Now, "Saque maior que o saldo disponível.")
            );
        }
    }
}
