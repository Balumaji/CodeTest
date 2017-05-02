using DeependCmsTest.Models.Pages;
using Our.Umbraco.Ditto;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Zoombraco.Controllers;
using Zoombraco.Models;

namespace DeependCmsTest.Controllers
{
    public class HomeController : ZoombracoController
    {
        // GET: BasePage
        public override ActionResult Index(RenderModel model)
        {
            Home home = model.As<Home>();
            RenderPage<Home> viewModel = new RenderPage<Home>(home);

            return this.CurrentTemplate(viewModel);
        }
    }
}