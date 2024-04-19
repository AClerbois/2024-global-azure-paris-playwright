using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sot.Rebuild.AutomatedTests.Helpers;
using System.Threading.Tasks;

namespace Sot.Rebuild.AutomatedTests.PageTests;

public abstract class BasePageTest : PageTest
{
    protected PageContextHelper PageContext;

    [TestInitialize]
    public async Task TestInitializeAsync()
    {
        PageContext = new PageContextHelper(Page, TestContext);
        await PageContext.StartTracingAsync();
    }

    [TestCleanup]
    public async Task TestCleanupAsync()
    {
        await PageContext.StopTracingAsync();
    }

}
