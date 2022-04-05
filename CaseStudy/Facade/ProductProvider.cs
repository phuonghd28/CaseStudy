using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    class ProductProvider : IProduct
    {

        public void CreateProduct()
        {
            Console.WriteLine("Create Product doing");
        }
    }
}
