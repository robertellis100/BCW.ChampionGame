﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public interface ISummaryItemGroup
    {
        List<SummaryItem> ItemSummaryList { get; set; }
    }
}
