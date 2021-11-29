const { test, expect } = require('@playwright/test');

test('VerifyGuilhermePage', async ({ page }) => {
  await page.goto('https://guilhermestaffen.tech/#/');
  const content = page.locator('h1');
  await expect(content).toHaveText('Guilherme Staffen');
});


