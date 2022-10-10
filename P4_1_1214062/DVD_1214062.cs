using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214062
{
    internal class DVD_1214062 : Product_1214062
    {
        protected string duration;

        public DVD_1214062(string title, string duration) //Method Constructor dengan 2 parameter
        {
            this.MyType = "DVD";
            this.MyTitle = title;
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD!!!");
        }

        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
