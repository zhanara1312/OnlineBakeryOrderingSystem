using System;

namespace OnlineBakeryOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************");
            Console.WriteLine("Welcome to our bakery!");
            Console.WriteLine("***************");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a profile");
                Console.WriteLine("2. Order online");
                Console.WriteLine("3. Print my order");
                Console.WriteLine("4. Print my transactions");
                Console.Write("Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the bakery!");
                        return;
                    case "1":
                        try
                        {
                            Console.Write("Customer name: ");
                            var customerName = Console.ReadLine();

                            Console.Write("Customer Address: ");
                            var customerAddress = Console.ReadLine();

                            Console.Write("Customer Email Address: ");
                            var customerEmailAddress = Console.ReadLine();                    

                            Console.Write("Customer Bank account number : ");
                            var customerBankAccountNumber = Console.ReadLine();

                            var bakeryProducts = Enum.GetNames(typeof(BakeryProduct));
                            for (int i = 0; i < bakeryProducts.Length; i++)
                            {
                                Console.WriteLine($"{i}. {bakeryProducts[i]}");
                            }
                            Console.Write("Bakery product: ");
                            var bakeryProduct = Enum.Parse<BakeryProduct>(Console.ReadLine());

                            Console.Write("Number of order: ");
                            var order = Convert.ToInt32(Console.ReadLine());

                            var a1 = BakeryOrder.CreateOrder(customerName, customerAddress, customerEmailAddress, customerBankAccountNumber, bakeryProduct, order);
                            Console.WriteLine($"Menu: {a1.BakeryProduct}, IP: {a1.ItemPrice}, CD: {a1.Date}, NO: {a1.NumberOfOrder}, CN: {a1.CustomerName}, CA: {a1.CustomerAddress}, EA: {a1.CustomerEmailAddress}, CBA: {a1.CustomerBankAccountNumber}");
                        }
                        catch (ArgumentNullException nx)
                        {
                            Console.WriteLine($"Emaill Address Error - {nx.Message} - Please try again!");
                        }
                        catch (ArgumentException ax)
                        {
                            Console.WriteLine($"Bakery Product Error - {ax.Message} - Please try again!");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Number of Order error - Please provide a valid amount. Try again!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Sorry something went wrong - {ex.Message} - please try again");
                        }
                        break;
                    case "2":
                        PrintAllBakeries();
                        break;
                    case "3":
                        PrintAllBakeries();
                        break;
                    case "4":
                        PrintAllTransactions();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintAllTransactions()
        {
            PrintAllBakeries();
            Console.Write("Customer number: ");
            var customerNumber = Convert.ToInt32(Console.ReadLine());
            var transactions = BakeryOrder.GetTransactionsForCustomerNumber(customerNumber);
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"Id: {transaction.TransactionId}, Date: {transaction.TransactionDate}, Type: {transaction.TransactionType}, Amount: {transaction.NumberOfOrder}");
            }
        }

        private static void PrintAllBakeries()
        {
            Console.Write("Email Address: ");
            var customerEmailAddress = Console.ReadLine();
            var bakeries = BakeryOrder.GetBakeryOrderForUser(customerEmailAddress);
            foreach (var bakery in bakeries)
            {
                Console.WriteLine($"Menu: {bakery.BakeryProduct}, IP: {bakery.ItemPrice}, CD: {bakery.Date}, NO: {bakery.NumberOfOrder}, CN: {bakery.CustomerName}, CA: {bakery.CustomerAddress}, EA: {bakery.CustomerEmailAddress}, CBA: {bakery.CustomerBankAccountNumber}");
            }
        }

    }

}
