static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for +, 2 for -, 3 for / and 4 for x");
            int userChoice = Convert.ToInt32(Console.ReadLine()); 
            if (userChoice == 1)
            {
                Console.WriteLine(NumbersAdd());
            }

            else if (userChoice == 2)
            {
                Console.WriteLine(NumberSub());
            }

            else if (userChoice == 3)
            {
                Console.WriteLine(NumberDivide());
            }

            else if (userChoice == 4)
            {
                Console.WriteLine(NumberTimes());
            }
        }

        static double NumbersAdd()
        {

            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double answer = num1 + num2;

            return answer;

        }

        static double NumberSub()
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double answer = num1 - num2;

            return answer;
        }

        static double NumberDivide()
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double answer = num1 / num2;

            return answer;
        }

        static double NumberTimes()
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double answer = num1 * num2;

            return answer;
        }

    


 
    
 
