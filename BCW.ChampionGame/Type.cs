using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ChampionGame
{
    public class Type : IType
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Type(int typeId, string name, string description)
        {
            this.TypeId = typeId;
            this.Name = name;
            this.Description = description;          
        }

    }
}
