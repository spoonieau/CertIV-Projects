using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEIICS.BusinessLogicLayer
{
    class ProductTypes
    {
        private string productType;
        private int productTypeID;

        public int ProductTypeID
        {
            get { return productTypeID; }
            set { productTypeID = value; }
        }

        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public ProductTypes() { }

        public ProductTypes(int productTypeID, string productType)
        {
            ProductTypeID = productTypeID;
            ProductType = productType;
        }
    }
}
