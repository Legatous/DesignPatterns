using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{

    interface IFactory<Brand> where Brand : IBrand
    {
        ITrackSuits CreateSuits();
        IShoes CreateShoes();
    }
}

