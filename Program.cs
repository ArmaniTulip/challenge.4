namespace challenge._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();

            Console.Write("Enter the desired width: ");
            string widthInput = Console.ReadLine();

            int number;
            int width;
            bool isNumberValid = int.TryParse(numberInput, out number);
            bool isWidthValid = int.TryParse(widthInput, out width);

            if (isNumberValid && isWidthValid && width > 0)
            {
                for (int i = width; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(number);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}
