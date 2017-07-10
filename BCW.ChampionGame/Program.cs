using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var willysStore = new Store("Willy's Store");
            var myTypeSet = new TypeSet();
            var myCart = new Cart();
            var pick = new Item("Old Rusty", "A well worn pick it doesn't look like this would last long", 20, 0);
            var weapon = new Type(0, "Weapon", "Tool used to attack opponents");
            var shield = new Item("Knight's Shield", "A nice looking shield with an unknown emblem", 200, 1);
            var protection = new Type(1, "Protection", "Deffensive tool used to protect yourself from attacks of opponents");

            //willysStore.AddItemToItemList(pick);
            //willysStore.AddItemToItemList(shield);
            willysStore.ItemList.Add(pick);
            willysStore.ItemList.Add(shield);
            myTypeSet.TypeList.Add(weapon);
            myTypeSet.TypeList.Add(protection);

            Console.WriteLine("Welcome to " + willysStore.ManagerName);
            willysStore.ViewItems(willysStore.ItemList);
            var item = willysStore.GetItemByName("Old Rusty", willysStore.ItemList);
            myCart.AddItemToItemList(item);
            myCart.ViewItems(myCart.ItemList);
            Console.WriteLine("Total Price of All Items in Cart: "+myCart.CalculateTotalPriceOfItemList(myCart.ItemList));
            Console.WriteLine("Total Quantity of Items in Cart: "+myCart.CalculateTotalQuantityOfItemList(myCart.ItemList));
            Console.WriteLine("Total Quantity of Items in Cart by Item Type: ");
            var storeInventorySummary = willysStore.SummarizeItemListTotalQuantityByItemType(myTypeSet, willysStore.ItemList);
            foreach (var it in storeInventorySummary.ItemSummaryList)
            {
                Console.WriteLine(it.TypeName + "       Quantity: " + it.TypeQuantity);
                Console.WriteLine(it.TypeDescription + "        First: " + it.Name);

            }
            Console.ReadLine();

        }
    }
}
