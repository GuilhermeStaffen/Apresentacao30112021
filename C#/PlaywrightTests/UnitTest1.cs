using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;
namespace PlaywrightNew
{
    [TestFixture]
    public class Program
    {
        [Test]
        public static async Task VerifyGuilhermePage()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions{ 
                    Headless = false, SlowMo = 50, 
                }
            );
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://guilhermestaffen.tech/#/");
            string content = await page.InnerTextAsync("h1");
            Assert.AreEqual("Guilherme Staffen", content);
        }
    }
}


