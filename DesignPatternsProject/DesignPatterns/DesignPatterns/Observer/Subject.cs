using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    abstract class ASubject
    {

        ArrayList list = new ArrayList();

        public delegate void StatusUpdate(float price);
        public event StatusUpdate OnStatusUpdate = null;

        public void Attach(Shop product)
        {

            list.Add(product);
        }


        public void Attach2(Shop product)
        {
            //For way 2 lets assign attach the observers with subjects
            OnStatusUpdate += new StatusUpdate(product.Update);
        }


        public void Notify(float price)
        {

            foreach (Shop p in list)
            {
                p.Update(price);
            }


            if (OnStatusUpdate != null)
            {
                OnStatusUpdate(price);
            }
        }
    }
}
