using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class SummaryItemGroup : ISummaryItemGroup
    {
        public List<SummaryItem> ItemSummaryList { get; set; } = new List<SummaryItem>();
    }
}
