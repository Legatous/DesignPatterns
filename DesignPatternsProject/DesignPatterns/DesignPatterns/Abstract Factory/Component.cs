using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "The shoes model that cost 200 is:";
        }

    }
}
