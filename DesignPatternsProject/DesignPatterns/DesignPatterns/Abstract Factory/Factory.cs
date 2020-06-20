using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{

    class Factory<Brand> : IFactory<Brand>
    where Brand : IBrand, new()
    {
        public ITrackSuits CreateSuits()
        {
            return new TrackSuits<Brand>();
        }

        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();

        }
    }
}