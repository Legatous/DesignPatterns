using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Adidas : IBrand
    {
        public int Price
        {
            get
            {
                return 200;
            }
        }
        public string Material
        {
            get
            {
                return "Cotton";
            }
        }
    }
}
