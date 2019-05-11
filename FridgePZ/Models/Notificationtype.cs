using System;
using System.Collections.Generic;

namespace FridgePZ.Models
{
    public partial class Notificationtype
    {
        public Notificationtype()
        {
            Categoryitempattern = new HashSet<Categoryitempattern>();
            Item = new HashSet<Item>();
        }

        public int NotificationId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Categoryitempattern> Categoryitempattern { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
