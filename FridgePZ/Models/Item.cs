using System;
using System.Collections.Generic;

namespace FridgePZ.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public int ShelfId { get; set; }
        public int ItemPatternId { get; set; }
        public int? NotificationId { get; set; }
        public decimal? HowMuchLeft { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public byte? IsOpen { get; set; }

        public virtual Itempattern ItemPattern { get; set; }
        public virtual Notificationtype Notification { get; set; }
        public virtual Shelf Shelf { get; set; }
    }
}
