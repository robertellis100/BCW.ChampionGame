using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class Store : ItemGroupManager
    {
        
        public Store(string storeName)
        {
            this.ManagerName = storeName;
            
        }

        public List<Item> ItemList { get; set; } = new List<Item>();
    }
}
