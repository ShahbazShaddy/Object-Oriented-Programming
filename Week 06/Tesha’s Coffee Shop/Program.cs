using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop teshaCoffeeShop = new CoffeeShop("Tesha's Coffee Shop");

            // Adding menu items
            teshaCoffeeShop.AddMenuItem(new MenuItem("orange juice", "Drink", 60));
            teshaCoffeeShop.AddMenuItem(new MenuItem("lemonade", "Drink", 50));
            teshaCoffeeShop.AddMenuItem(new MenuItem("cranberry juice", "Drink", 100));
            teshaCoffeeShop.AddMenuItem(new MenuItem("pineapple juice", "Drink", 100));
            teshaCoffeeShop.AddMenuItem(new MenuItem("lemon iced tea", "Drink", 120));
            teshaCoffeeShop.AddMenuItem(new MenuItem("vanilla chai latte", "Drink", 150));
            teshaCoffeeShop.AddMenuItem(new MenuItem("hot chocolate", "Drink", 140));
            teshaCoffeeShop.AddMenuItem(new MenuItem("iced coffee", "Drink", 140));
            teshaCoffeeShop.AddMenuItem(new MenuItem("tuna sandwich", "Food", 300));
            teshaCoffeeShop.AddMenuItem(new MenuItem("ham and cheese sandwich", "Food", 300));
            teshaCoffeeShop.AddMenuItem(new MenuItem("egg sandwich", "Food", 200));
            teshaCoffeeShop.AddMenuItem(new MenuItem("steak", "Food", 900));
            teshaCoffeeShop.AddMenuItem(new MenuItem("hamburger", "Food", 600));
            teshaCoffeeShop.AddMenuItem(new MenuItem("cinnamon roll", "Food", 150));

            Console.WriteLine("Welcome to the Tesha's Coffee Shop");
            Console.WriteLine("1. Add a Menu item");
            Console.WriteLine("2. View the Cheapest Item in the menu");
            Console.WriteLine("3. View the Drink's Menu");
            Console.WriteLine("4. View the Food's Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill the Order");
            Console.WriteLine("7. View the Orders's List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");

            bool exit = false;
            while (!exit)
            {
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of the item: ");
                        string itemName = Console.ReadLine();
                        Console.Write("Enter the type of the item (Drink/Food): ");
                        string itemType = Console.ReadLine();
                        Console.Write("Enter the price of the item: ");
                        double itemPrice = Convert.ToDouble(Console.ReadLine());

                        teshaCoffeeShop.AddMenuItem(new MenuItem(itemName, itemType, itemPrice));
                        Console.WriteLine("Menu item added successfully!");
                        break;

                    case 2:
                        string cheapestItem = teshaCoffeeShop.CheapestItem();
                        if (cheapestItem != "")
                        {
                            Console.WriteLine($"The cheapest item in the menu is: {cheapestItem}");
                        }
                        else
                        {
                            Console.WriteLine("No items in the menu.");
                        }
                        break;

                    case 3:
                        List<string> drinksMenu = teshaCoffeeShop.DrinksOnly();
                        Console.WriteLine("Drink's Menu:");
                        if (drinksMenu.Count > 0)
                        {
                            foreach (string drink in drinksMenu)
                            {
                                Console.WriteLine(drink);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No drinks available in the menu.");
                        }
                        break;

                    case 4:
                        List<string> foodMenu = teshaCoffeeShop.FoodOnly();
                        Console.WriteLine("Food's Menu:");
                        if (foodMenu.Count > 0)
                        {
                            foreach (string food in foodMenu)
                            {
                                Console.WriteLine(food);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No food available in the menu.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter the name of the item to add in the order: ");
                        string orderItemName = Console.ReadLine();
                        string result = teshaCoffeeShop.AddOrder(orderItemName);
                        if (result == "")
                        {
                            Console.WriteLine("Item added to the order successfully!");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                        break;

                    case 6:
                        string fulfillOrderResult = teshaCoffeeShop.FulfillOrder();
                        Console.WriteLine(fulfillOrderResult);
                        break;

                    case 7:
                        List<string> ordersList = teshaCoffeeShop.ListOrders();
                        Console.WriteLine("Orders's List:");
                        if (ordersList != null)
                        {
                            foreach (string order in ordersList)
                            {
                                Console.WriteLine(order);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No orders placed yet.");
                        }
                        break;

                    case 8:
                        double totalAmount = teshaCoffeeShop.DueAmount();
                        Console.WriteLine($"Total payable amount: {totalAmount}");
                        break;

                    case 9:
                        exit = true;
                        Console.WriteLine("Thank you for visiting Tesha's Coffee Shop. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
