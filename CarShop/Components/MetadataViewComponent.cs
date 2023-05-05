using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp.ColorSpaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.Blocks;

namespace CarShop.Components
{
    public class MetadataViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(NavigationViewModel viewModel)
        {
            var metadata = new MetadataViewModel
            {
                Title = viewModel.Content.Value<string>("pageTitle"),
                Description = viewModel.Content.Value<string>("pageDescription"),
                Keywords = string.Join(",", viewModel.Content.Value<string[]>("keywords"))
            };
            
            if (string.IsNullOrEmpty(metadata.Title))
            {
                metadata.Title = viewModel.Settings.PageTitle;
            }

            if (string.IsNullOrEmpty(metadata.Description))
            {
                metadata.Description = viewModel.Settings.PageDescription;
            }

            if (string.IsNullOrEmpty(metadata.Keywords))
            {
                metadata.Keywords = string.Join(",", viewModel.Settings.Keywords);
            }

            return View("Metadata", metadata);
        }
    }
}

