namespace OddOrEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // User inputs a number
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                //check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

        }
    }
}
