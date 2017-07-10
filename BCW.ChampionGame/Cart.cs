using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class Cart : ItemGroupManager
    {
        public Cart()
        {
            
        }
        public List<Item> ItemList { get; set; } = new List<Item>();
    }
}
