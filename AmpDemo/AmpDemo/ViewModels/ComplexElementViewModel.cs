using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace AmpDemo.ViewModels
{
    public class ComplexElementViewModel : MasterPageViewModel
    {
        public override Task Load()
        {
            Date=DateTime.Now;
            return base.Load();
        }

        public DateTime Date { get; set; }

        public void GoBack()
        {
            Date = Date.AddDays(-1);
        }
    }
}

