using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class SummaryItem : ISummaryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int TypeId { get; set; }
        public int Quantity { get; set; } = 0;
        public int TypeQuantity { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
    }
}
