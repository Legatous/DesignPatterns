using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    class Nike : IBrand
    {
        public int Price
        {
            get
            {
                return 2000;
            }
        }
        public string Material
        {
            get
            {
                return "is 100% polyester";
            }
        }
    }
}