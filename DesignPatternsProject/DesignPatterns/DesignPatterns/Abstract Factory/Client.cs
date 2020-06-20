using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    class Client<Brand> where Brand : IBrand, new()
    {
        public void ClientMain()
        {

            IFactory<Brand> factory = new Factory<Brand>();

            ITrackSuits tracksuits = factory.CreateSuits();
            IShoes shoes = factory.CreateShoes();

            Console.WriteLine("Tha Adidas tracksuit is made of " + tracksuits.Material);
            Console.WriteLine("Tha Nike tracksuit is made of " + tracksuits.Material);
            Console.WriteLine("The shoes are costing " + shoes.Price);
        }
    }
}