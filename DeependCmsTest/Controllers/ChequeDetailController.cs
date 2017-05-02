using DeependCmsTest.Models.Pages;
using Our.Umbraco.Ditto;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Zoombraco.Controllers;
using Zoombraco.Models;

namespace DeependCmsTest.Controllers
{
    public class ChequeDetailController : ZoombracoController
    {
        public ActionResult ChequeDetail(RenderModel model, string contentId)
        {
            var parent = model.Content.Parent;
            ChequesList chequeList = parent.As<ChequesList>();
            var list = ContentHelper.GetById<ChequesList>(parent.Id);

            var chqDtl = list.ListOfCheques.FirstOrDefault(c => c.Name.Equals(contentId, System.StringComparison.InvariantCultureIgnoreCase));
            
            ChequeDetail chequeDtl = model.As<ChequeDetail>();
            chequeDtl.ChequeDtl = chqDtl;

            RenderPage<ChequeDetail> viewModel = new RenderPage<ChequeDetail>(chequeDtl);

            return this.CurrentTemplate(viewModel);
        }
    }
}