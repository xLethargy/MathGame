namespace MathGame
{
    public class MathOperators
    {
        MathGameBeginning mathGameBeginning = new MathGameBeginning();
        public void PerformAdd()
        {
            bool checkValid = false;
            float total = 0;

            LayoutQuestion("Add");

            do
            {
                var userInput = Console.ReadLine();
                string[] numbersToAdd = userInput.Split(',');

                foreach (string number in numbersToAdd)
                {
                    checkValid = float.TryParse(number, out float parsedNumber);
                    total += parsedNumber;

                    if (!checkValid)
                    {
                        Console.WriteLine("Invalid Entry. Please enter integers separated by commas");
                        total = 0;
                    }
                }
            } while (!checkValid);

            Console.WriteLine("\nYour total sum is {0}", total);

            ReplayMathGame();
        }

        

        public void PerformSubtract()
        {
            bool checkValid = false;
            float total = 0;
            float count = 0;
            LayoutQuestion("Subtract");

            do
            {
                var userInput = Console.ReadLine();
                string[] numbersToAdd = userInput.Split(',');

                foreach (string number in numbersToAdd)
                {
                    checkValid = float.TryParse(number, out float parsedNumber);

                    if (!checkValid)
                    {
                        Console.WriteLine("Invalid Entry. Please enter integers separated by commas");
                        total = 0;
                        count = 0;
                    }
                    else if (count == 0)
                    {
                        total = parsedNumber;
                        count++;

                    }
                    else
                    {
                        total -= parsedNumber;
                    }
                }
            } while (!checkValid);

            Console.WriteLine("\nYour total sum is {0}", total);

            ReplayMathGame();
        }

        

        public void PerformDivide()
        {
            bool checkValid = false;
            float total = 0;
            int count = 0;

            LayoutQuestion("Divide");

            do
            {
                var userInput = Console.ReadLine();
                string[] numbersToAdd = userInput.Split(',');

                foreach (string number in numbersToAdd)
                {
                    checkValid = float.TryParse(number, out float parsedNumber);

                    if (!checkValid)
                    {
                        Console.WriteLine("Invalid Entry. Please enter integers separated by commas");
                        total = 0;
                        count = 0;
                    }
                    else if (count == 0)
                    {
                        total = parsedNumber;
                        count++;

                    }
                    else
                    {
                        total /= parsedNumber;
                    }
                }
            } while (!checkValid);

            Console.WriteLine("\nYour total sum is {0}", total);

            ReplayMathGame();
        }
        public void PerformMultiply()
        {
            bool checkValid = false;
            float total = 0;
            int count = 0;

            LayoutQuestion("Multiply");

            do
            {
                var userInput = Console.ReadLine();
                string[] numbersToAdd = userInput.Split(',');

                foreach (string number in numbersToAdd)
                {
                    checkValid = float.TryParse(number, out float parsedNumber);

                    if (!checkValid)
                    {
                        Console.WriteLine("Invalid Entry. Please enter integers separated by commas");
                        total = 0;
                        count = 0;
                    }
                    else if (count == 0)
                    {
                        total = parsedNumber;
                        count++;

                    }
                    else
                    {
                        total *= parsedNumber;
                    }
                }
            } while (!checkValid);

            Console.WriteLine("\nYour total sum is {0}", total);

            ReplayMathGame();
        }
        private void ReplayMathGame()
        {
            Console.Write("\nWould you like to use another operator: ");
            var operatorAnswer = Console.ReadLine();
            switch (operatorAnswer.ToLower())
            {
                case "yes":
                    mathGameBeginning.BeginningQuestion();
                    break;
                case "no":
                    break;
            }
        }
        private void LayoutQuestion(string givenOperator)
        {

            Console.WriteLine("You have chosen {0}\n", givenOperator);
            Console.Write("Please enter your digits to {0} separated by a colon: ", givenOperator.ToLower());
        }
    }
}