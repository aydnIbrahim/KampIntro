using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductIntro
{
    internal class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart : "+product.productName);
        }

        public void update(Product product)
        {
            Console.WriteLine("Updated to cart : "+ product.productName);
        }

        public void delete(Product product) {
            Console.WriteLine("Deleted to cart : "+product.productName);
        }
       
    }
}
