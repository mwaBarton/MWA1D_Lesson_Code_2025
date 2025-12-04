using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L131___List_of_Structures
{

    public struct ShoppingListItem
    {
        public string name;
        public int quantity;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingListItem> shoppingList = new List<ShoppingListItem>();

            ShoppingListItem item = new ShoppingListItem()
            {
                name = "Egg",
                quantity = 12
            };

            shoppingList.Add(item);

            shoppingList.Add(new ShoppingListItem()
            {
                name = "Bread",
                quantity = 2
            });


            foreach (ShoppingListItem i in shoppingList)
            {
                Console.WriteLine($"{i.quantity} {i.name}{((i.quantity > 1) ? "s" : "")}");
            }

            Console.ReadKey();
        }
    }
}
