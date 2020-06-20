using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    class ComponentD : IComponentD
    {
        public string Operation()
        {
            return "The shoes model that cost 200 is:";
        }

    }
}
