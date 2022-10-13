using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();

var browser = await playwright.Chromium.LaunchPersistentContextAsync(@"C:\Users\Dan\AppData\Local\Google\Chrome\User Data", new BrowserTypeLaunchPersistentContextOptions
{
    Headless = false,
});

var page = await browser.NewPageAsync();
await page.GotoAsync("https://google.com");

Console.ReadKey();

