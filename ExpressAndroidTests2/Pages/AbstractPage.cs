using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ExpressAndroidTests2.Pages
{
    public class AbstractPage
    {
        readonly protected IApp app;

        public Query Button(string buttonName)
        {
            return  c => c.Id("permButton").Text(buttonName);
        }

        public AbstractPage(IApp app)
        {
            this.app = app;
        }

        public void PressButton(String name)
        {
            Query buttonName = Button(name);
            app.Tap(buttonName);
        }

        public bool CheckIfButtonIsDisplayed(String name)
        {
            Query buttonName = Button(name);
            if (app.WaitForElement(buttonName).Any() == false)
            {
                return false;
            }
            return true;
        }
    }
}
