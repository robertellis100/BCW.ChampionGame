using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int TypeId { get; set; }

        public Item(string name, string description, decimal price, int typeId)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.TypeId = typeId;
        }
    }
}
