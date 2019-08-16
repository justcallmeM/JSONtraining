using System;
using System.Collections.Generic;
using System.Text;

namespace trainingJSON
{
    public class Product
    {
        public string imagePath { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public List<string> photos { get; set; }
    }
    public class ProductList
    {
        public List<Product> productList { get; set; }
    }
    //public class Database
    //{
    //    public ProductList database { get; set; }
    //}
}
