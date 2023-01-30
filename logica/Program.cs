namespace logica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("=Bem vindo ao sistema=");
            Console.WriteLine("===============================");

            Console.WriteLine("Insira o nome do investidor:");
            string? clientName = Console.ReadLine();
            Console.WriteLine("Qual o valor que deseja depositar?");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Deseja sacar? Sim(1) ou Não(2)");
            int userAction = Convert.ToInt16(Console.ReadLine());

            double valorDoSaque = 0;
            do
            {
                valorDoSaque = 0;
                switch (userAction)
                {
                    case 1:
                        Console.WriteLine("Qual o valor que deseja sacar?");
                        valorDoSaque += Convert.ToDouble(Console.ReadLine());
                        break;
                    case 2:
                        break;
                }

                if (valorDoSaque > saldo)
                {
                    Console.WriteLine("O valor do saque é maior que o seu saldo.");
                }
            } while (valorDoSaque > saldo);

            Console.WriteLine($"O valor sacado foi R$ {valorDoSaque} e o seu saldo é de R$ {saldo - valorDoSaque}");

            Console.WriteLine("===============[Finalizando o sistema]================");
        }
    }
}
