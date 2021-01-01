using RobotFramework.BasePage;
using RobotFramework.Waits;
using RobotTasks.NotForMerge.Pages;

namespace RobotTasks.NotForMerge.Tasks
{
    public class MediaLibraryTasks : MainClass
    {
        public void Login()
        {
            var login = new LoginPage(GetDriver(), GetWaitMethods());
            login.EnterIntoServer();
        }

        public void OpenMediaLibrary()
        {
            StartDriverWorkflow();
            GetDriver().Navigate().GoToUrl("https://regression.surpass-preview.com/");
            Login();
        }
    }
}