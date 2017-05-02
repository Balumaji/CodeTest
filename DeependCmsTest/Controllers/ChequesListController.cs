using DeependCmsTest.Models.Pages;
using Our.Umbraco.Ditto;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Zoombraco.Controllers;
using Zoombraco.Models;

namespace DeependCmsTest.Controllers
{
    public class ChequesListController : ZoombracoController
    {
        public override ActionResult Index(RenderModel model)
        {
            ChequesList chequeList = model.As<ChequesList>();
            RenderPage<ChequesList> viewModel = new RenderPage<ChequesList>(chequeList);

            return this.CurrentTemplate(viewModel);
        }
    }
}