using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms.Internals;

using ExpMenu.Infrastructure;
using ExpMenu.Models;
using Xamarin.Forms;

namespace ExpMenu.ViewModels
{
    public class SelectCategoryViewModel
    {
        public Category Category { get; set; }
        public bool Selected { get; set; }
    }

    public class MasterPageViewModel : BindableBase
    {
        public ObservableCollection<Grouping<SelectCategoryViewModel, Item>> Categories { get; set; }

        public DelegateCommand<Grouping<SelectCategoryViewModel, Item>> HeaderSelectedCommand
        {
            get
            {
                return new DelegateCommand<Grouping<SelectCategoryViewModel, Item>>(g =>
                {
                    if (g == null) return;
                    g.Key.Selected = !g.Key.Selected;
                    if (g.Key.Selected)
                    {
                        Item datacontrol = Data.DataFactory.DataItems.FirstOrDefault(x => (x.Category.IsSub == false && x.Category.CategoryId == g.Key.Category.CategoryId));
                        if (datacontrol == null) {
                            Data.DataFactory.DataItems.Where(i => (i.Category.CategoryId == g.Key.Category.CategoryId)).ForEach(g.Add);
                        } else {
                            //Sub menüsü yoksa yapılacak işlemler
                            var mdp = Application.Current.MainPage as MasterDetailPage;
                            mdp.Detail = new NavigationPage((Page)Activator.CreateInstance(datacontrol.Category.TargetType));
                            mdp.IsPresented = false;
                        }
                    }
                    else
                    {
                        g.Clear();
                    }
                });
            }
        }

        public MasterPageViewModel()
        {
            Categories = new ObservableCollection<Grouping<SelectCategoryViewModel, Item>>();
            var selectCategories =
                Data.DataFactory.DataItems.Select(x => new SelectCategoryViewModel { Category = x.Category, Selected = false })
                    .GroupBy(sc => new { sc.Category.CategoryId })
                    .Select(g => g.First())
                    .ToList();
            selectCategories.ForEach(sc => Categories.Add(new Grouping<SelectCategoryViewModel, Item>(sc, new List<Item>())));
        }
    }
}
