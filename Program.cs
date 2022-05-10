using System;

namespace Ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o títular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá um depósito inicial?");
            Console.Write("(S/N): ");
            string depoRequest = Console.ReadLine().ToLower();
           
            Product pessoa = new Product();
            pessoa.AdicionarConta(conta);
            pessoa.AdicionarNome(nome);

            string resposta = "Dados da conta atualizados:";
            double deposito; 
            if (depoRequest == "s")
            {
                Console.Write("Entre com o valor de depósito inicial: "); 
                deposito = double.Parse(Console.ReadLine());
                pessoa.DepositarValor(deposito);
            }

            Console.WriteLine();
            Console.WriteLine(resposta);
            Console.WriteLine(pessoa);
            Console.WriteLine();

            Console.WriteLine("Deseja fazer um depósito?");
            Console.Write("(S/N): ");
            depoRequest = Console.ReadLine().ToLower() ;

            if (depoRequest == "s")
            {
                Console.Write("Entre com o valor do depósito: ");
                deposito = double.Parse(Console.ReadLine());
                pessoa.DepositarValor(deposito);
            }
            Console.WriteLine();
            Console.WriteLine(resposta);
            Console.WriteLine(pessoa);
            Console.WriteLine();

            Console.WriteLine("Deseja realizar um saque?");
            Console.Write("(S/N): ");
            depoRequest = Console.ReadLine().ToLower();

            if (depoRequest == "s")
            {
                Console.Write("Entre com o valor do Saque: ");
                deposito = double.Parse(Console.ReadLine());
                pessoa.SacarValor(deposito);
            }
            Console.WriteLine();
            Console.WriteLine(resposta);
            Console.WriteLine(pessoa);
            Console.WriteLine();

        }
    }
}
