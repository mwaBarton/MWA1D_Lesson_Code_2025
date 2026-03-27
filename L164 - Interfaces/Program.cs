using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L164___Interfaces
{
    public class Weapon : IBreakable, IDoDamage, IInventoryItem
    {
        int durability = 50;
        int damage = 10;

        public double attack()
        {
            if (!isBroken()) return damage;

            breakABit();
            return 0;
        }

        public void breakABit()
        {
            durability -= 5;
            if (durability < 0) durability = 0;
        }

        public string getDescription()
        {
            return "Weapon";
        }

        public bool isBroken()
        {
            return durability == 0;
        }
    }

    public class Food : IConsumable, IBreakable, IInventoryItem
    {
        int bitesLeft = 5;

        public void breakABit()
        {
            bitesLeft--;
            if (bitesLeft < 0) bitesLeft = 0;
        }

        public void consume()
        {
            breakABit();
        }

        public string getDescription()
        {
            return "Food";
        }

        public bool isBroken()
        {
            return bitesLeft == 0;
        }
    }



    internal class Program
    {
        static List<IInventoryItem> inventory = new List<IInventoryItem>();

        static void itemSelected(IInventoryItem item)
        {
            if (item is IConsumable)
            {
                Console.WriteLine("Would you like to consume? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    ((IConsumable)item).consume();
                    return;
                }
            }
        }

        static void selectItem()
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(i + ": " + inventory[i].getDescription());
            }

            Console.Write("Choose item: ");
            int index = int.Parse(Console.ReadLine());

            itemSelected(inventory[index]);
        }

        static void Main(string[] args)
        {
            inventory.Add(new Weapon());
            inventory.Add(new Food());
            inventory.Add(new Food());

            while (true)
            {
                selectItem();
            }
        }
    }
}
