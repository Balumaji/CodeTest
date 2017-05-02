using DeependCmsTest.Models.NestedComponents;
using Zoombraco.Models;

namespace DeependCmsTest.Models.Pages
{
    public class ChequeDetail : Page
    {
        public string PageTitle { get; set; }
        public NestedCheque ChequeDtl { get; set; }
    }
}