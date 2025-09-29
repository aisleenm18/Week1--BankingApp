/*
 * *Class name: BankingApp
 * Version 1
 * Author: Aisleen Marcus
 */

void BuildBankingApp()
{
    int choice;
    double depositAmount;
    double accountBalance = 1000;

    // Main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("========================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read users choice 
    //Convert string to an integer

    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            // Deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much would you like to deposit");
            Console.WriteLine("Enter the amount");

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance is {accountBalance}");

            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if (choice == 2)
        {
            Console.WriteLine("You have chosen to view your account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else
        {
            accountBalance = 1000.00;
            Console.WriteLine($"Your current account balance is {accountBalance}");

            // View account information
            Console.WriteLine("You have chosen to view your account information");
        }
    }
    else
    {
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

        BuildBankingApp();
    
