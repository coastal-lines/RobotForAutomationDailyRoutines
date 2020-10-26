using OneMoreCSharpFramework.Source.Driver.Waits;
using OneMoreCSharpFramework.src.driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OneMoreCSharpFramework.src.pages
{
    public abstract class BasePage : DriverClass
    {
        public IWebDriver driver;
        public WaitMethods waitMethods;

        public BasePage() 
        {
            this.driver = DriverClass.GetDriver();
            PageFactory.InitElements(DriverClass.GetDriver(), this);
        }

        public WaitMethods WaitMethods => waitMethods ?? new WaitMethods(driver);
    }
}