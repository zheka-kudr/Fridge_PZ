using System;
using System.Collections.Generic;

namespace FridgePZ.Models
{
    public partial class Accesstype
    {
        public Accesstype()
        {
            Privilege = new HashSet<Privilege>();
        }

        public int AccessTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Privilege> Privilege { get; set; }
    }
}
