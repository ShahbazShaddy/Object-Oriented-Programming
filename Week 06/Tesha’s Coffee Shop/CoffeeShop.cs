using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06a
{
    internal class CoffeeShop
    {
        private string Name { get; set; }
        private List<MenuItem> Menu { get; set; }
        private List<string> Orders { get; set; }

        public CoffeeShop(string name)
        {
            Name = name;
            Menu = new List<MenuItem>();
            Orders = new List<string>();
        }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }

        public string AddOrder(string itemName)
        {
            foreach (MenuItem item in Menu)
            {
                if (item.Name == itemName)
                {
                    Orders.Add(itemName);
                    return "";
                }
            }
            return "This item is currently unavailable!";
        }

        public string FulfillOrder()
        {
            if (Orders.Count > 0)
            {
                string item = Orders[0];
                Orders.Clear();
                return $"The {item} is ready!";
            }
            return "All orders have been fulfilled!";
        }

        public List<string> ListOrders()
        {
            if (Orders.Count > 0)
            {
                return Orders;
            }
            return null;
        }

        public double DueAmount()
        {
            double totalAmount = 0;
            foreach (string order in Orders)
            {
                foreach (MenuItem item in Menu)
                {
                    if (item.Name == order)
                    {
                        totalAmount += item.Price;
                    }
                }
            }
            return totalAmount;
        }

        public string CheapestItem()
        {
            if (Menu.Count > 0)
            {
                MenuItem cheapestItem = Menu[0];
                foreach (MenuItem item in Menu)
                {
                    if (item.Price < cheapestItem.Price)
                    {
                        cheapestItem = item;
                    }
                }
                return cheapestItem.Name;
            }
            return "";
        }

        public List<string> DrinksOnly()
        {
            List<string> drinks = new List<string>();
            foreach (MenuItem item in Menu)
            {
                if (item.Type == "Drink")
                {
                    drinks.Add(item.Name);
                }
            }
            return drinks;
        }

        public List<string> FoodOnly()
        {
            List<string> food = new List<string>();
            foreach (MenuItem item in Menu)
            {
                if (item.Type == "Food")
                {
                    food.Add(item.Name);
                }
            }
            return food;
        }
    }
}
