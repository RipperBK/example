using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Product : Object
    {
        public Product()
        {

        }

        public Product(string id, string name, double costPrice, double retailPrice = 0) 
        {
            Id = id;
            Name = name;
            CostPrice = costPrice;
            RetailPrice = retailPrice;
        }

        public override bool Equals(object obj) => obj is Product && ((Product)obj).Id == Id;
            //if (obj is Product)
            //{
             //   Product otherProduct = (Product)obj;
              //  return Id == otherProduct.Id;
            //}
            //else
            //{
             //   return false;
            //}
        
        public string Id { get; set; }
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public virtual double RetailPrice { get; set; }
    }
}
