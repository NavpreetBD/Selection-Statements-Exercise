namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize favorite number
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            // Prompt user to guess the number
            Console.WriteLine("Guess my favorite number (between 1 and 1000):");
            var userInput = int.Parse(Console.ReadLine());

            // Check if the guessed number is below, equal to, or above the initial value
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!!!");
            }
    }
}
