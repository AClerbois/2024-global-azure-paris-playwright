using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sot.Rebuild.AutomatedTests.PageModels;
using Sot.Rebuild.AutomatedTests.PageTests;
using System.Threading.Tasks;

namespace Sot.Rebuild.AutomatedTests;

[TestClass]
public class NavigationFlowTests : BasePageTest
{
    [TestMethod]
    public async Task Flow_Home_ToPage1_ToPlanning()
    {
        var homePage = new HomePageModel(Page, PageContext, this);
        await homePage.GoToAsync();
        await PageContext.TakeScreenshotAsync();
        var page1 = await homePage.ClickOnButtonForPage1Async();
        await PageContext.TakeScreenshotAsync();
        await page1.ScrollToLastSectionAsync();
        await PageContext.TakeScreenshotAsync();
        var planningPage = await page1.ClickToPlanningAsync();
        await PageContext.TakeScreenshotAsync(planningPage.GetPlanningImageLocator());
    }
}