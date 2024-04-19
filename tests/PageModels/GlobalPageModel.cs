using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Sot.Rebuild.AutomatedTests.Helpers;
using System.Threading.Tasks;

namespace Sot.Rebuild.AutomatedTests.PageModels;

public class GlobalPageModel
{
    private readonly IPage _page;
    private readonly PageContextHelper _context;
    private readonly PlaywrightTest _playwrightTest;

    public GlobalPageModel(
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
    }

    public async Task AssertEnvironmentAsync()
    {
        await _playwrightTest
            .Expect(GetEnvironnementLocator())
            .ToHaveTextAsync(_context.GetEnvironment());
    }

    public ILocator GetEnvironnementLocator()
    {
        return _page.GetByTestId("environment");
    }
}
