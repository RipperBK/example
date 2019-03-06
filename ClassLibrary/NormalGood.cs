using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class NormalGood : Product
    {
        public NormalGood()
        {

        }

        public NormalGood(string id, string name, double costPrice) : base (id, name, costPrice)
        {
            
        }
        public override double RetailPrice
        {
            get { return CostPrice * 2.5; }
        }
    }
}
