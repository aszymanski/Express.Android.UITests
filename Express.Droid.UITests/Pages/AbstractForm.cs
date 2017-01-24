using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Expres.Droid.UITests.Pages
{
    public class AbstractForm : AbstractPage
    {
        public Query QuestionHeader(string questionHeader)
        {
            return c => c.Class("TextView").Text(questionHeader);
        }

        readonly protected IApp app;
        public AbstractForm(IApp app)
            : base(app)
        {
        }
    }
}
