﻿namespace CleanArchitecture.WebUI.AcceptanceTests.Pages;

public abstract class BasePage
{
    public static string BaseUrl => ConfigurationHelper.GetBaseUrl();

    public abstract string PagePath { get; }

    public abstract IBrowser Browser { get; }

    public abstract IPage Page { get; }

    public async Task GotoAsync()
    {
        await Page.GotoAsync(PagePath);
    }
}
