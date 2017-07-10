using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        int TypeId { get; set; }
    }
}
