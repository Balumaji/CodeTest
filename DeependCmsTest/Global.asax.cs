using System;
using System.Configuration;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.Routing;
using Umbraco.Web.Cache;
using Umbraco.Core;
using DeependCmsTest.Controllers;

namespace PacDig.OscarWinter.Web
{
    public class WebApplication : UmbracoApplication
    {
        public override void Init()
        {
            base.Init();
        }

        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            base.OnApplicationStarting(sender, e);

            // save some cycles for each view or template request
            //ViewEngines.Engines.Remove(new WebFormViewEngine());
            //DefaultRenderMvcControllerResolver.Current.SetDefaultControllerType(typeof(BasePageController));
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {            
            base.OnApplicationStarted(sender, e);
        }                
    }
}
