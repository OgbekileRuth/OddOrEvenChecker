namespace CheckOddOrEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // loop to keep running
            {
                Console.WriteLine("Enter a number (or type 'exit' to quit): ");
                string input = Console.ReadLine();

                // use break to exit the loop
                if (input.ToLower() == "exit")
                {
                    break;
                }

                int number = Convert.ToInt32(input);

                // Call the method
                CheckOddOrEven(number);
            }

            Console.WriteLine("Program ended.");
        }

        // Method to check odd or even
        static void CheckOddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }
        }
    }
    }