 while (true)
    {
        Console.WriteLine("\nPlease choose an operation:");
        Console.WriteLine("0. Exit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            
            case 0:
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }