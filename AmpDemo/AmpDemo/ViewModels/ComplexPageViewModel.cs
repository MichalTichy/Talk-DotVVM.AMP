using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace AmpDemo.ViewModels
{
    public class ComplexPageViewModel : MasterPageViewModel
    {
        public ICollection<Food> AvailableItems { get; set; }
        public int SelectedFoodItem { get; set; }
        public Food DeliveredItem { get; set; }
        public override Task Load()
        {

            AvailableItems = new List<Food>()
            {
                new Food()
                {
                    Id = 1,
                    Name = "Pizza",
                    Url = @"https://www.carusopizza.cz/185/9.jpg"
                },
                new Food()
                {
                    Id = 2,
                    Name = "Burger",
                    Url = @"https://5.imimg.com/data5/LR/WE/GLADMIN-14821295/bacon-king-jr-sandwich-500x500.png"
                },
                new Food()
                {
                    Id = 3,
                    Name = "Salad",
                    Url = @"https://www.carusopizza.cz/460-large_default/mezzogiorno.jpg"
                }
            };
            return base.Load();
        }

        public void Order()
        {
            DeliveredItem = AvailableItems.SingleOrDefault(t => t.Id == SelectedFoodItem);
        }
    }

    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        
    }
}

