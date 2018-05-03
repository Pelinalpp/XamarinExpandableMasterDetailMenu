using System;
using System.Collections.Generic;
using System.Text;

namespace ExpMenu.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemTitle { get; set; }
        public Type ItemTargetType { get; set; }

        public Category Category { get; set; }
    }
}
