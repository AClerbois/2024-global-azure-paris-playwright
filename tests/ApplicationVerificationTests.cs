using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sot.Rebuild.AutomatedTests.PageModels;
using Sot.Rebuild.AutomatedTests.PageTests;
using System.Threading.Tasks;

namespace Sot.Rebuild.AutomatedTests;

[TestClass]
public class ApplicationVerificationTests : BasePageTest
{
    [TestMethod]
    public async Task ApplicationVerification()
    {
        var page = new GlobalPageModel(Page, PageContext, this);
        await page.GoToAsync();
        await page.AssertEnvironmentAsync();
        await PageContext.TakeScreenshotAsync();
        await PageContext.TakeScreenshotAsync(page.GetEnvironnementLocator());
    }
}