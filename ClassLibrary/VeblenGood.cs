using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class VeblenGood : Product
    {
        public VeblenGood()
        {

        }

        public VeblenGood(string id, string name, double costPrice) : base(id, name, costPrice)
        {
           
        }
        public override double RetailPrice
        {
            get { return CostPrice * 5; }
        }
    }
}
