using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UltimateGamingPCs
{
    /// <summary>
    /// Summary description for UGPWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UGPWebService : System.Web.Services.WebService
    {

        public struct PcDetails
        {
            public string ProductCode;
            public string ProductTitle;
            public string ProductDescription;
            public decimal ProductPrice;
        }

        private PcDetails details;

        public UGPWebService()
        {
            details.ProductCode = "";
            details.ProductTitle = "";
            details.ProductDescription = "";
            details.ProductPrice = 0;
        }

        private void setPcDetailValues(string ProductCode)
        {
            details.ProductCode = ProductCode;

            if (details.ProductCode.Equals("UG1"))
            {
                details.ProductTitle = "UG Hunter";
                details.ProductDescription = "Intel I7/3.4GHZ, 8GB RAM, 32GB SSD, 1TB HHD, Gigabyte GeForce GT710";
                details.ProductPrice = 1999.00m;
            }
            else if (details.ProductCode.Equals("UG2"))
            {
                details.ProductTitle = "UG Predator";
                details.ProductDescription = "Intel I7/4GHZ, 16GB RAM, 128GB SSD, 2TB HHD, Gigabyte GeForce GT730";
                details.ProductPrice = 2499.00m;
            }
            else if (details.ProductCode.Equals("UG3"))
            {
                details.ProductTitle = "UG Beast";
                details.ProductDescription = "Intel I7/4GHZ, 32GB RAM, 256GB SSD, 2TB HHD, Gigabyte GeForce GT750";
                details.ProductPrice = 2999.00m;
            }
            else
            {
                details.ProductTitle = "Product Code not found.";
                details.ProductDescription = "No Description";
                details.ProductPrice = 0;
            }
        }

        [WebMethod(Description = "This method call will get the product Title, it's description and current sales price. ", EnableSession = false)]
        public PcDetails GetPcDetails(string ProductCode)
        {
            setPcDetailValues(ProductCode);
            PcDetails RequestedPcDetails = new PcDetails();
            RequestedPcDetails.ProductCode = details.ProductCode;
            RequestedPcDetails.ProductTitle = details.ProductTitle;
            RequestedPcDetails.ProductDescription = details.ProductDescription;
            RequestedPcDetails.ProductPrice = details.ProductPrice;
            return RequestedPcDetails;
            
        }
            
    }

}

