using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Sot.Rebuild.AutomatedTests.Helpers;

namespace Sot.Rebuild.AutomatedTests.PageModels;

internal class PlanningPageModel
{
    private readonly IPage _page;
    private readonly PageContextHelper _context;
    private readonly PlaywrightTest _playwrightTest;

    public PlanningPageModel(
        IPage page,
        Helpers.PageContextHelper context,
        PlaywrightTest playwrightTest)
    {
        _page = page;
        _context = context;
        _playwrightTest = playwrightTest;
    }

    public ILocator GetPlanningImageLocator()
    {
        return _page.GetByRole(AriaRole.Img);
    }
}