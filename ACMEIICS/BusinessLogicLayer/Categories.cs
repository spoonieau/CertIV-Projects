using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEIICS.BusinessLogicLayer
{
    class Categories
    {
        private string category;
        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Categories() { }

        public Categories(int categoryid, string category)
        {
            CategoryID = categoryid;
            Category = category;
        }
    }
}
