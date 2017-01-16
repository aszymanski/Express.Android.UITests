using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using System.Linq;

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

        [When(@"I fill the Online Form 1")]
        public void WhenIFillOnlineForm1()
        {
            ScrollStrategy strategy = ScrollStrategy.Auto;
            app.WaitForElement(c => c.Class("TextView").Text("What filing status will you use on your 2016 Income Tax Return?"));
            app.Tap(c => c.Class("Textview").Text("Single"));
            app.ScrollDownTo(c => c.Class("TextView").Text("Can someone else claim you as a dependent on his or her tax return?"));
            app.Tap(c => c.Class("ToggleButton").Text("Yes"));
            app.ScrollDownTo(c => c.Class("TextView").Text("How many dependents (other than yourself and your spouse ) you will claim on your tax return?"));
            app.ClearText(c => c.Class("EditText"));
            app.EnterText(c => c.Class("EditText"),"1");
            app.Back();
            app.ScrollDownTo(c => c.Class("TextView").Text("Are you going to file as head of household?"));
            app.Tap(c => c.Class("ToggleButton").Text("Yes").Index(0));
            app.Tap(c => c.Class("ToggleButton").Text("Yes").Index(1));

            app.ScrollDownTo(c => c.Id("month"));
            AppResult[] result = app.Query(c => c.Id("numberpicker_input").Text("Jun"));

            while (result.Any() == false)
            {
                Console.WriteLine("Rezultaty" + result.Any());
                app.ScrollDown((m => m.Id("month")), strategy, 0.30, 900);
                app.Tap(m => m.Id("month"));
                result = app.Query(c => c.Id("numberpicker_input").Text("Jun"));

            }
            app.EnterText(c => c.Id("year"), "2001");
            app.EnterText(c => c.Id("day"), "11");
            app.PressUserAction();
        }

         [When(@"I scroll down to Sign In button")]
        public void ScrollToSignItButton()
        {
            app.ScrollDownTo(c => c.Class("Button").Text("Sign it!"));
        }

    
        [When(@"I tap ""(.*)"" button")]
        public void WhenITapButtoon(string buttonName)
        {
            app.Tap(c => c.Class("Button").Text(buttonName));
        }

        [When(@"I perform a signature")]
        public void WhenIPerformASignature()
        {
            ScrollStrategy strategy = ScrollStrategy.Auto;
            app.ScrollDown((m => m.Id("signatureView")), strategy, 0.30, 900);
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
            app.WaitForElement(c => c.Id("action_bar_title").Text(screenName));         

        }
    }
}
