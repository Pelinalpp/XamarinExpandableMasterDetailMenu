using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpMenu.Models;
using ExpMenu.Views;

namespace ExpMenu.Data
{
    public static class DataFactory
    {
        public static IList<Item> DataItems { get; private set; }

        private static readonly Category Category1 = new Category { CategoryId = 1, CategoryTitle = "Category 1", IsSub = true, TargetType = null };
        private static readonly Category Category2 = new Category { CategoryId = 2, CategoryTitle = "Category 2", IsSub = true, TargetType = null };
        private static readonly Category Category3 = new Category { CategoryId = 3, CategoryTitle = "Category 3", IsSub = false, TargetType = typeof(ThirdPage) };
        private static readonly Category Category4 = new Category { CategoryId = 4, CategoryTitle = "Category 4", IsSub = false, TargetType = typeof(FourthPage) };

        static DataFactory()
        {
            DataItems = new ObservableCollection<Item>()
            {
                new Item
                {
                    ItemId = 1,
                    ItemTitle = "Item 1",
                    Category = Category1,
                    ItemTargetType = typeof(MainPage)
                },
                new Item
                {
                    ItemId = 2,
                    ItemTitle = "Item 2",
                    Category = Category1,
                    ItemTargetType = typeof(SecondPage)
                },
                new Item
                {
                    ItemId = 3,
                    ItemTitle = "Item 3",
                    Category = Category2,
                    ItemTargetType = typeof(MainPage)
                },
                new Item
                {
                    ItemId = 4,
                    ItemTitle = "Item 4",
                    Category = Category2,
                    ItemTargetType = typeof(SecondPage)
                },
                new Item
                {
                    ItemId = 5,
                    ItemTitle = "",
                    Category = Category3
                },
                new Item
                {
                    ItemId = 6,
                    ItemTitle = "",
                    Category = Category4
                }
            };
        }
    }
}
