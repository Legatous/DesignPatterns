using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{

    class Shoes<Brand> : IShoes where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Shoes()
        {

            myBrand = new Brand();
        }

        public int Price
        {
            get
            {
                return myBrand.Price;
            }
        }
    }
}