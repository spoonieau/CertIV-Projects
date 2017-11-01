using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEIICS.BusinessLogicLayer
{
    class Sales
    {
        private int saleID, customerID, productID;
        private string startDate;
        private char payable;

        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public char Payable
        {
            get { return payable; }
            set { payable = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public Sales() { }

        public Sales(int saleID, int customerID, int productID, char payable, string startDate)
        {
            SaleID = saleID;
            CustomerID = customerID;
            ProductID = productID;
            Payable = payable;
            StartDate = startDate;
        }
    }
}
