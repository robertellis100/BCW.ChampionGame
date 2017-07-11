using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public interface IItemGroupManager:IItemGroup
    {
        //void AddItemToItemList(Item item, ItemGroup itemGroup);
        //void RemoveItemFromItemList(Item item, ItemGroup itemGroup);
        //decimal CalculateTotalPriceOfItemList(ItemGroup itemGroup);
        //int CalculateTotalQuantityOfItemList(ItemGroup itemGroup);
        //ISummaryItemGroup SummarizeItemListTotalQuantityByItemType(ItemGroup itemGroup, TypeSet typeSet);
        void AddItemToItemList(Item item, List<Item> list);
        void RemoveItemFromItemList(Item item, List<Item> list);
        decimal CalculateTotalPriceOfItemList(List<Item> list);
        int CalculateTotalQuantityOfItemList(List<Item> list);
        ISummaryItemGroup SummarizeItemListTotalQuantityByItemType(TypeSet typeSet, List<Item> list);
        void ViewItems(List<Item> list);
        Item GetItemByName(string name, List<Item> list);
    }
}
