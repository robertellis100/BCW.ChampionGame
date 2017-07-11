using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class ItemGroupManager : IItemGroupManager
    {
        public List<Item> ItemList { get; set; } 
        public string ManagerName { get; set; }
        public void AddItemToItemList(Item item, List<Item> list)
        {
            list.Add(item);
        }

        public void RemoveItemFromItemList(Item item, List<Item> list)
        {
            list.Remove(item);
        }

        public decimal CalculateTotalPriceOfItemList(List<Item> list)
        {
            //decimal _totalPrice = 0;
            //foreach (var item in itemGroup.ItemList)
            //{
            //    _totalPrice += item.Price;
            //}
            //return _totalPrice;
            return list.Sum(item => item.Price);
        }

        public int CalculateTotalQuantityOfItemList(List<Item> list)
        {
            return list.Count();
        }


        public ISummaryItemGroup SummarizeItemListTotalQuantityByItemType(TypeSet typeSet, List<Item> list)
        {
            var summary = new SummaryItemGroup();
            foreach (var type in typeSet.TypeList) //for each type in items add up all items for that type
            {
                var summaryItem = new SummaryItem(); 
                //var firstItem = itemGroup.ItemList.Where(item => item.TypeId == type.TypeId).FirstOrDefault();
                var firstItem = list.FirstOrDefault(item => item.TypeId == type.TypeId);
                summaryItem.TypeId = firstItem.TypeId;
                summaryItem.Name = firstItem.Name;
                summaryItem.Description = firstItem.Description;
                summaryItem.Price = firstItem.Price;
                //summaryItem.Quantity++;

                foreach (var item in list.Where(e => e.TypeId == type.TypeId)) 
                {
                    summaryItem.Quantity++;
                }
                summary.ItemSummaryList.Add(summaryItem);
            }
            return summary;
        }

        public void ViewItems(List<Item> list)
        {
            Console.WriteLine("Item Name        Description             Price       ");
            foreach (var item in list)
            {
                Console.WriteLine(item.Name+"       "+item.Description+"       "+item.Price);
            }
        }

        public Item GetItemByName(string name, List<Item> list)
        {
            return list.FirstOrDefault(item => item.Name == name);
        }
    }
}
