using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp.ColorSpaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Services;


namespace CarShop.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILocalizationService _localizationService;
        public NavigationViewComponent(ILocalizationService localizationService)
        {
            _localizationService = localizationService;
        }

        public async Task<IViewComponentResult> InvokeAsync(NavigationViewModel navigationViewModel)
        {
            var allCultures = _localizationService.GetAllLanguages().ToDictionary(x => x.IsoCode, x => x.CultureName);

            navigationViewModel.AvailableCultures = allCultures;

            return View("Navigation", navigationViewModel);
        }
    }
}

