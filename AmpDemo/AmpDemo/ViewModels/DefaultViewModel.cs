using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace AmpDemo.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set;}

        public string Html { get; set; } =
            $"<h2>Dynamic text from server</h2><p>\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, lacus sed imperdiet convallis, elit orci dictum libero, quis tincidunt libero ex at risus. Aenean sollicitudin vitae enim ut facilisis. Vestibulum id nisi elit. Integer at tincidunt lorem, nec tincidunt erat. Aenean ac ultricies mi, eu consequat metus. Ut congue interdum mauris vitae dignissim. Praesent sagittis, dui sollicitudin dignissim rutrum, massa tellus tempus nulla, sed vestibulum nisi elit sed tellus. Integer posuere nulla at nisl dignissim, eu vestibulum tortor fermentum.</p><p>Mauris consectetur sem sed nunc convallis, ut commodo nisi vestibulum. Cras pharetra rhoncus lacus vitae convallis. Aliquam imperdiet eget velit vitae consequat. Mauris at pulvinar sem. Proin interdum ac turpis eget consectetur. Praesent eleifend ut lectus vitae tempor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc facilisis imperdiet ex, ut dictum odio. In tempor libero ac felis ornare porta.</p>";
        public List<Data> Data { get; set; }
		public DefaultViewModel()
		{
			Title = "Hello from DotVVM AMP!";
		}

        public override Task PreRender()
        {
            Data = new List<Data>()
            {
                new Data()
                {
                    Index = 1,
                    Text = "Hello"
                },
                new Data()
                {
                    Index = 2,
                    Text = "from"
                },

                new Data()
                {
                    Index = 3,
                    Text = "DotVVM AMP"
                }
            };

            return base.PreRender();
        }
    }

    public class Data
    {
        public int Index { get; set; }
        public string Text { get; set; }
    }
}
