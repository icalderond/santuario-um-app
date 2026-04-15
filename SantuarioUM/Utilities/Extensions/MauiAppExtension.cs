using System.Resources;
using SantuarioUM.Pages;
using SantuarioUM.Utilities.Interfaces;
using SantuarioUM.Utilities.Services;
using SantuarioUM.ViewModels;

namespace SantuarioUM.Utilities.Extensions;

public static class MauiAppExtensions
{
     /// <summary>
    /// Register Pages
    /// </summary>
    /// <param name="mauiAppBuilder"></param>
    /// <returns></returns>
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<AppShell>();
        mauiAppBuilder.Services.AddSingleton<DashPage>();
        mauiAppBuilder.Services.AddSingleton<ArticlePage>();
        mauiAppBuilder.Services.AddSingleton<ParentArticlePage>();

        return mauiAppBuilder;
    }

    /// <summary>
    /// Register ViewModels
    /// </summary>
    /// <param name="mauiAppBuilder"></param>
    /// <returns></returns>
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
         mauiAppBuilder.Services.AddTransient<IAppShellViewModel, AppShellViewModel>();
         mauiAppBuilder.Services.AddTransient<IDashViewModel, DashViewModel>();
         mauiAppBuilder.Services.AddTransient<IArticleViewModel, ArticleViewModel>();
         mauiAppBuilder.Services.AddTransient<IParentArticleViewModel, ParentArticleViewModel>();
        
        return mauiAppBuilder;
    }

    /// <summary>
    /// Register Services
    /// </summary>
    /// <param name="mauiAppBuilder"></param>
    /// <returns></returns>
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();
        return mauiAppBuilder;
    }

    /// <summary>
    /// Register Shell Routes
    /// </summary>
    /// <param name="mauiAppBuilder"></param>
    public static MauiAppBuilder RegisterShellRoutes(this MauiAppBuilder mauiAppBuilder)
    {
        Routing.RegisterRoute(nameof(AppShellViewModel), typeof(AppShell));
        Routing.RegisterRoute(nameof(DashViewModel), typeof(DashPage));
        Routing.RegisterRoute(nameof(ArticleViewModel), typeof(ArticlePage));
        Routing.RegisterRoute(nameof(ParentArticleViewModel), typeof(ParentArticlePage));

        return mauiAppBuilder;
    }
}