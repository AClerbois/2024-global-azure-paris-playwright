using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Sot.Rebuild.AutomatedTests.Helpers;
using System.Threading.Tasks;

namespace Sot.Rebuild.AutomatedTests.PageModels;

internal class HomePageModel
{
    private readonly IPage _page;
    private readonly PageContextHelper _context;
    private readonly PlaywrightTest _playwrightTest;

    public HomePageModel(
        IPage page,
        Helpers.PageContextHelper context,
        PlaywrightTest playwrightTest)
    {
        _page = page;
        _context = context;
        _playwrightTest = playwrightTest;
    }

    public async Task GoToAsync()
    {
        await _page.GotoAsync(_context.GetAppUrl());
        await _playwrightTest.Expect(_page).ToHaveTitleAsync("Playwright Demo - Playwright Demo");
    }

    public async Task<Page1Model> ClickOnButtonForPage1Async()
    {
        await _page.GetByTestId("go-page1").ClickAsync();
        return new Page1Model(_page, _context, _playwrightTest);
    }
}
