using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Decorator;
using DesignPatterns.Observer;
using DesignPatterns.Abstract_Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Client for two different brand
            //abstract factory
            new Client<Adidas>().ClientMain();
            new Client<Nike>().ClientMain();
            //decorator
            static void Display(string s, IComponentD c)
            {
                Console.WriteLine(s + c.Operation());
            }
            IComponentD component = new ComponentD();
            Display("", new DecoratorClass(component));

            //observer
            Product product = new Product();

            Shop shop1 = new Shop("Shop 1");
            Shop shop2 = new Shop("Shop 2");
            Shop shop3 = new Shop("Shop 3");

            product.Attach(shop1);
            product.Attach(shop2);
            product.Attach2(shop3);

            product.ChangePrice(23.0f);

            Console.Read();
        }
    }
}
