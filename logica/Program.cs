namespace logica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========Seja Bem vindo ao Sistema==========");

            string? option = "";

            List<string[]> clientDb = new List<string[]>();

            decimal balance = 0;

            do
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Cadastrar o cliente");
                Console.WriteLine("2 - Ver conta corrente");
                Console.WriteLine("3 - Fazer credito em conta");
                Console.WriteLine("4 - Fazer debito em conta");
                Console.WriteLine("5 - Sair do sistema");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        registerClient(clientDb);
                        break;
                    case "2":
                        Console.Clear();
                        showBalance(balance);
                        break;
                    case "3":
                        Console.Clear();
                        depositOnAccount(balance);
                        break;
                    case "4":
                        Console.Clear();
                        withdrawFromAccount(balance);
                        break;

                }

            } while (option != "5");
        

            Console.WriteLine("=============Encerrando o sistema=============");
        }

        static void registerClient(List<string[]> clientDb )
        {
            string[] client = new string[4];
            client[0] = Guid.NewGuid().ToString();

            Console.Clear();
            Console.WriteLine("Digite o nome do cliente:");
            string? name = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente:");
            string? phoneNumber = Console.ReadLine();
            Console.WriteLine("Digite o email do cliente:");
            string? email = Console.ReadLine();
            // Operador ternário
            client[1] = name != null ? name : ""; 
            client[2] = phoneNumber != null ? phoneNumber : "";
            client[3] = email != null ? email : "";

            clientDb.Add(client);
        }

        static void showBalance(decimal balance)
        {
            Console.WriteLine($"O saldo da sua conta corrente é de R$ {balance}");
            Thread.Sleep(3000);
            Console.Clear();
        }

        static void depositOnAccount(decimal balance)
        {
            // Code to deposit
        }

        static void withdrawFromAccount(decimal balance)
        {
            // Code to withdraw
        }
    }
}
