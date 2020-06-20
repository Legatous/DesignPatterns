using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    interface IObserver
    {
        void Update(float price);
    }
}
