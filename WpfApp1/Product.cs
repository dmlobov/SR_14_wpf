using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public enum ProductCategoryes
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductSize { get; set; }
        public int ProductImage { get; set; }
        public ProductCategoryes ProductCategory { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }


}
