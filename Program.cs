 while (true)
    {
        Console.WriteLine("\nPlease choose an operation:");
        Console.WriteLine("1. Addition");  
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("0. Exit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Addition_Neko();
                break;
            case 2:
                Subtraction();
                break;
            case 0:
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        
        static void Addition_Neko()
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
    }