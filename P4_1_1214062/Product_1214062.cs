using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214062
{
    internal class Product_1214062
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;

        public Product_1214062()
        {
            
        }

        public Product_1214062(string type, string title) //Method Constructor
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
