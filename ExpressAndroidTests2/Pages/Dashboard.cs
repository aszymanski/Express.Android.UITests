using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;


namespace ExpressAndroidTests2.Pages
{
    public class Dashboard : AbstractPage
    {

        public Dashboard(IApp app)
            : base(app)
        {
        }

        public void Test()
        {
            app.Back();
        }
    }
    
}
