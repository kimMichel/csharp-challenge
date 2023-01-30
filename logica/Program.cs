namespace logica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("=Bem vindo ao sistema=");
            Console.WriteLine("===============================");

            Console.WriteLine("Digite o primeiro número a ser calculado:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número a ser calculado:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===========================================");

            Console.WriteLine("Digite a opção desejada: 1 - Adição, 2 - Subtração, 3 - Multiplicação, 4 - Divisão");
            int option = Convert.ToInt16(Console.ReadLine());
            int total = 0;

            // if (option == 1)
            // {
            //     total = firstNumber + secondNumber;
            // }
            // else if (option == 2)
            // {
            //     total = firstNumber - secondNumber;
            // }
            // else if (option == 3)
            // {
            //     total = firstNumber * secondNumber;
            // } 
            // else
            // {
            //     total = firstNumber / secondNumber;
            // }

            switch (option)
            {
                case 1:
                    total = firstNumber + secondNumber;
                    break;
                case 2:
                    total = firstNumber - secondNumber;
                    break;
                case 3:
                    total = firstNumber * secondNumber;
                    break;
                case 4:
                    total = firstNumber / secondNumber;
                    break;
            }



            Console.WriteLine($"O total da operação é de {total}");

            Console.WriteLine("===============[Finalizando o sistema]================");
        }
    }
}
