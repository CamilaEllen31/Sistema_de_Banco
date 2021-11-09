using System;

namespace CS_BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteCamila = new Gerente()
            {
                Nome = "Camila",
                CPF = "425.238.556-34",
                Salario = 10000,
                NumeroDeAgencias = 2,
            };

            Vendedor vendedorPedro = new Vendedor()
            {
                Nome = "Pedro",
                CPF = "123.556.139-12",
                Salario = 2000,
                NumeroClientesAtendidos = 3,
            };

            Vendedor vendedorSilvana = new Vendedor()
            {
                Nome = "Silvana",
                CPF = "109.876.543-11",
                Salario = 3000,
                NumeroClientesAtendidos = 8,
            };

            Vendedor VendedorRogerio = new Vendedor()
            {
                Nome = "Rogerio",
                CPF = "591.643.22-11",
                Salario = 4000,
                NumeroClientesAtendidos = 12,
            };

            vendedorSilvana.Bonificacao = vendedorSilvana.Salario;
            vendedorPedro.Bonificacao = vendedorPedro.Salario;
            gerenteCamila.Bonificacao = gerenteCamila.Salario;
            VendedorRogerio.Bonificacao = VendedorRogerio.Salario;

            ContaCorrente contaRebeca = new ContaCorrente("Rebeca", 4421, 15000, VendedorRogerio);
            contaRebeca.Conta = 789;
            ContaCorrente contaAna = new ContaCorrente("Ana", 4248, 12000, vendedorSilvana);
            contaAna.Conta = 789;
            ContaCorrente contaThulio = new ContaCorrente("Thulio", 0562, 20000, vendedorPedro);
            contaThulio.Conta = 123;

            Console.WriteLine("Contas:\n");
            Console.WriteLine("Conta 1:\nNome: " + contaRebeca.Titular +
            "\nAgência: " + contaRebeca.Agencia +
            "\nSaldo: " + contaRebeca.Saldo);

            Console.WriteLine("\nConta 2:\nNome: " + contaAna.Titular +
            "\nAgência: " + contaAna.Agencia +
            "\nSaldo: " + contaAna.Saldo);

            Console.WriteLine("\nConta 3:\nNome: " + contaThulio.Titular +
            "\nAgência: " + contaThulio.Agencia +
            "\nSaldo: " + contaThulio.Saldo);

            Console.WriteLine("\n---------------------\nFuncinários:\n");
            Console.WriteLine("Vendedor 1:\nNome: " + vendedorPedro.Nome +
            "\nCPF: " + vendedorPedro.CPF + "\nSalário: " + vendedorPedro.Salario +
            "\nBonificação: " + vendedorPedro.Bonificacao +
            "\nDias de férias: " + vendedorPedro.CalcularFerias() +
            "\nRemuneração total: " + vendedorPedro.RemuneracaoTotal(vendedorPedro.Salario, vendedorPedro.Bonificacao));

            Console.WriteLine("\nVendedor 2:\nNome: " + vendedorSilvana.Nome +
            "\nCPF: " + vendedorSilvana.CPF + "\nSalário: " + vendedorSilvana.Salario +
            "\nBonificação: " + vendedorSilvana.Bonificacao +
            "\nDias de férias: " + vendedorSilvana.CalcularFerias() +
            "\nRemuneração total: " + vendedorSilvana.RemuneracaoTotal(vendedorSilvana.Salario, vendedorSilvana.Bonificacao));

            Console.WriteLine("\nVendedor 3:\nNome: " + VendedorRogerio.Nome +
            "\nCPF: " + VendedorRogerio.CPF + "\nSalário: " + VendedorRogerio.Salario +
            "\nBonificação: " + VendedorRogerio.Bonificacao +
            "\nDias de férias: " + VendedorRogerio.CalcularFerias() +
            "\nRemuneração total: " + VendedorRogerio.RemuneracaoTotal(VendedorRogerio.Salario, VendedorRogerio.Bonificacao));

            Console.WriteLine("\nGerente:\nNome: " + gerenteCamila.Nome +
            "\nCPF: " + gerenteCamila.CPF + "\nSalário: " + gerenteCamila.Salario +
            "\nBonificação: " + gerenteCamila.Bonificacao +
            "\nDias de férias: " + gerenteCamila.CalcularFerias() +
            "\nRemuneração total: " + gerenteCamila.RemuneracaoTotal(gerenteCamila.Salario));

            Console.WriteLine("\nContas criadas: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}
