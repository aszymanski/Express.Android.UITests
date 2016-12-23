using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace ExpressAndroidTests2
{
    [Binding]
    public class AddCallendarEventSteps
    {
        AndroidApp app;
        
        [BeforeScenario]
        public void SetUp()
        {
            app = ConfigureApp.Android.ApkFile("D:/express.droid(2).apk").StartApp();
        }

        [Given(@"Launch Repl")]
        public void LaunchRepl()
        {
            app.Repl();

        }

        [Given(@"I can see ""(.*)"" button")]
        public void GivenICanSeeButton(string buttonName)
        {
            app.WaitForElement(c => c.Marked(buttonName));

        }
        
        [When(@"I tap ""(.*)"" buttoon")]
        public void WhenITapButtoon(string buttonName)
        {
            app.Tap(c => c.Class("Button").Text(buttonName));
        }
        
        [Then(@"I can see ""(.*)"" button")]
        public void ThenICanSeeButton(string buttonName)
        {
            app.WaitForElement(c => c.Marked(buttonName));
        }

        [Then(@"Popup appears ""(.*)""")]
        public void ThenPopupAppear(string msg)
        {
            app.WaitForElement(c => c.Class("TextView").Text(msg));

        }

        [Then(@"I can see ""(.*)"" screen")]
        public void ThenICanSeeScreen(string screenName)
        {
            app.WaitForElement(c => c.Class("TextView").Text(screenName));
            app.ScrollDown();
            app.ScrollDown();

        }
    }
}
