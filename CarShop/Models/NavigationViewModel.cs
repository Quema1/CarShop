using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core.Services;
namespace CarShop.Models
{
    public class NavigationViewModel
    {
        public Settings Settings { get; set; }
        public IPublishedContent Content { get; set; }
        public string Culture { get; set; }

        public Dictionary<string, string> AvailableCultures { get; set; }

    }
}
