namespace MathGame
{
    public class MathGameBeginning
    {
        
        public void BeginningQuestion()
        {
            MathOperators mathOperators = new MathOperators();
            string userInput;
            bool validChoice = true;

            Console.WriteLine("Welcome to the Math Game\n");
            Console.WriteLine("Please choose which function you would like:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply\n");

            Console.Write("Please enter your choice: ");
            do
            {
                userInput = Console.ReadLine().ToString();
                switch (userInput.ToLower())
                {
                    case "add":
                        mathOperators.PerformAdd();
                        validChoice = true;
                        break;
                    case "subtract":
                        mathOperators.PerformSubtract();
                        validChoice = true;
                        break;
                    case "divide":
                        mathOperators.PerformDivide();
                        validChoice = true;
                        break;
                    case "multiply":
                        mathOperators.PerformMultiply();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, please enter 'Add', 'Subtract', 'Divide', or 'Multiply'");
                        validChoice = false;
                        break;
                }

            } while (!validChoice);
        }
    }
}