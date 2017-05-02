using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zoombraco.Models;

namespace DeependCmsTest.Models.NestedComponents
{
    public class NestedCheque : NestedComponent
    {
        public string ChequeName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}