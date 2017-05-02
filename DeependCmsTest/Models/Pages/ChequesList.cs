using DeependCmsTest.Models.NestedComponents;
using System.Collections.Generic;
using Zoombraco.Models;

namespace DeependCmsTest.Models.Pages
{
    public class ChequesList : Page
    {
        public string PageTitle { get; set; }
        public IEnumerable<NestedCheque> ListOfCheques { get; set; }
    }
}