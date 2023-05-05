using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp.ColorSpaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.Blocks;

namespace CarShop.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Settings settings)
        {
            var socialLinks = settings.SocialLinks;

            return View("Footer", socialLinks);
        }
    }
}

