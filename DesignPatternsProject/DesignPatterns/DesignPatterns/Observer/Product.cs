using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    class Product : ASubject
    {
        public void ChangePrice(float price)
        {
            Notify(price);
        }
    }
}