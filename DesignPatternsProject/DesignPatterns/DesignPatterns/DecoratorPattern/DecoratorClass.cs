using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    class DecoratorClass : IComponentD
    {
        IComponentD component;

        public DecoratorClass(IComponentD c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "Falcon W FV4483 made in:china material:cloth color:black available sizes:36,37,38,40,41,42 ";
            return s;
        }
    }
}
