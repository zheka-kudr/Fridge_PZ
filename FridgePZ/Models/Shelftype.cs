﻿using System;
using System.Collections.Generic;

namespace FridgePZ.Models
{
    public partial class Shelftype
    {
        public Shelftype()
        {
            Shelf = new HashSet<Shelf>();
        }

        public int ShelfTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Shelf> Shelf { get; set; }
    }
}
