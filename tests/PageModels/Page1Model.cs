using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Sot.Rebuild.AutomatedTests.Helpers;
using System;
using System.Threading.Tasks;

namespace Sot.Rebuild.AutomatedTests.PageModels;

internal class Page1Model
{
    private readonly IPage _page;
    private readonly PageContextHelper _context;
    private readonly PlaywrightTest _playwrightTest;

    public Page1Model(
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
        await _page
            .GotoAsync(_context.GetAppUrl());
        await _playwrightTest
            .Expect(_page)
            .ToHaveTitleAsync("Playwright Demo - Rebuild");
    }

    public async Task ScrollToLastSectionAsync()
    {
        await _page
            .GetByRole(AriaRole.Heading, new() { Name = "No server? No problem." })
            .ScrollIntoViewIfNeededAsync();
    }

    public async Task<PlanningPageModel> ClickToPlanningAsync()
    {
        await _page
            .GetByTestId("go-to-planning")
            .ClickAsync();
        return new PlanningPageModel(_page, _context, _playwrightTest);
    }
}
