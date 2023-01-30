namespace logica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("=Bem vindo ao sistema=");
            Console.WriteLine("===============================");

            Console.WriteLine("Quanto de combustivel tem disponivel? (L)");
            double gasQuantity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor do litro da gasolina?");
            double gasPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("===============================");
            Console.WriteLine("[Chegou um cliente]");
            Console.WriteLine("===============================");
            Console.WriteLine("Digite o nome do cliente:");
            string? clientName = Console.ReadLine();
            
            Console.WriteLine("Quanto de gasolina o cliente deseja colocar em reais:");
            double clientWillPay = Convert.ToDouble(Console.ReadLine());

            double gasInLiter = clientWillPay / gasPrice;
            gasQuantity -= gasInLiter;

            Console.WriteLine($"O cliente {clientName} pagou R${clientWillPay} por {gasInLiter} L de gasolina.");
            Console.WriteLine($"Resta {gasQuantity} L de gasolina no posto.");

            Console.WriteLine("===============[Finalizando o sistema]================");
        }
    }
}
