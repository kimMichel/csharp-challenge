namespace logica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("=Bem vindo ao primeiro sistema=");
            Console.WriteLine("===============================");

            Console.WriteLine("Digite o nome do primeiro colaborador:");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Digite o nome do segundo colaborador:");
            string? secondName = Console.ReadLine();

            Console.WriteLine("Digite o nome do terceiro colaborador:");
            string? thirdName = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do primeiro colaborador:");
            string? firstLastName = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do segundo colaborador:");
            string? secondLastName = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do terceiro colaborador:");
            string? thirdLastName = Console.ReadLine();

            Console.WriteLine("===============================");

            Console.WriteLine($"O primeiro colaborador se chama: {firstName + " " + firstLastName}");
            Console.WriteLine($"O segundo colaborador se chama: {secondName + " " + secondLastName}");
            Console.WriteLine($"O terceiro colaborador se chama: {thirdName + " " + thirdLastName}");

            Console.WriteLine("===============[Finalizando o sistema]================");
        }

    }
}
