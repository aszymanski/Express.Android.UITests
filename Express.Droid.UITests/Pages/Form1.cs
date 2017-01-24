using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;


namespace Expres.Droid.UITests.Pages
{
    public class Form1 : AbstractForm
    {

        public Form1(IApp app)
            : base(app)
        {
        }
    }
}
