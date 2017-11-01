using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEIICS.BusinessLogicLayer
{
    class Products
    {
        private string productName;
        private int productID, productTypeID;
        private decimal yearlyPremium;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public int ProductTypeID
        {
            get { return productTypeID; }
            set { productTypeID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }            
        }

        public decimal YearlyPremium
        {
            get { return yearlyPremium; }
            set { yearlyPremium = value; }
        }

        public Products() { }

        public Products(int productID, int productTypeID, string productName, decimal yearlyPremium)
        {
            ProductID = productID;
            ProductTypeID = productTypeID;
            ProductName = productName;
            YearlyPremium = yearlyPremium;
        }
    }
}
