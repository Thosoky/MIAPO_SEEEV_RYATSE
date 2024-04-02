 while (true)
    {
        Console.WriteLine("\nPlease choose an operation:");
        Console.WriteLine("1. Addition");  
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Square of a number");
        Console.WriteLine("6. Square root of a number");
        Console.WriteLine("0. Exit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Addition_Nek();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Multiplication();
                break;
            case 4:
                Division();
                break;
            case 5:
                Square();
                break;
            case 6:
                SquareRoot();
                break;
            case 0:
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        
        static void Addition_Nek()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result: {num1 + num2}");
        }

        static void Subtraction()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result: {num1 - num2}");
        }
        static void Multiplication()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result: {num1 * num2}");
        }

        static void Division()
        {
            Console.WriteLine("Enter the dividend:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero not allowed.");
            }
            else
            {
                Console.WriteLine($"Result: {num1 / num2}");
            }
        }
        static void Square()
        {
            Console.WriteLine("Enter the number:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result: {num * num}");
        }

        static void SquareRoot()
        {
            Console.WriteLine("Enter the number:");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Error: Square root of a negative number is not allowed.");
            }
            else
            {
                Console.WriteLine($"Result: {Math.Sqrt(num)}");
            }
        }
    }
