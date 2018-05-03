using System;
using System.Collections.Generic;
using System.Text;

namespace ExpMenu.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public bool IsSub { get; set; }
        public Type TargetType { get; set; }
    }
}
