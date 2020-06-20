using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    // This is all for tracksuits
    class TrackSuits<Brand> : ITrackSuits where Brand : IBrand, new()
    {
        private Brand myBrand;

        public TrackSuits()
        {
            myBrand = new Brand();
        }

        public string Material
        {
            get
            {
                return myBrand.Material;
            }
        }
    }
}

