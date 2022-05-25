using System;

namespace Ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de Banco NOSSO BANCO!");
            Console.WriteLine();
            Console.Write("Por favor, digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do títular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Cliente cliente = new(numeroConta, nome);

            Console.Write("Deseja realizar depósito inicial? [S/N]: ");
            string verificar = Console.ReadLine().ToLower();

            while (verificar == "s")
            {
                Console.Write("Digite o valor a ser depositado: R$ ");
                double saldo = double.Parse(Console.ReadLine());
                Console.WriteLine();

                cliente.AddSaldo(saldo);

                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(cliente);

                Console.Write("Deseja realizar mais algum depósito? [S/N]: ");
                verificar = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.Write("Deseja realizar um saque? [S/N]: ");
            string verificarSaque = Console.ReadLine().ToLower();

            while (verificarSaque == "s")
            {
                Console.Write("Digite o valor a ser sacado (existe uma taxa de R$ 5,00 a cada saque): R$ ");
                double saldo = double.Parse(Console.ReadLine());

                cliente.SacarSaldo(saldo);

                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(cliente);

                Console.WriteLine("Deseja realizar outro saque? [S/N]: ");
                verificarSaque = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.WriteLine($"obrigado por utilizar o nosso sistema, {cliente.Nome}!");
        }
    }
}
