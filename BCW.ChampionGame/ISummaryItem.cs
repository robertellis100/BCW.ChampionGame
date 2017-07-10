using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public interface ISummaryItem : IItem
    {
        int TypeQuantity { get; set; }
        string TypeName { get; set; }
        string TypeDescription { get; set; }
    }
}
