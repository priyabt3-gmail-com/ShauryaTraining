using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    interface Cake
    {
        void bake();
       
        
    }
    class Strawberry:Cake
    {
        public void bake()
        {
            Console.WriteLine("Strawberry Flovour");
        }
    }
    class Blackforest : Cake
    {
        public void bake()
        {
            Console.WriteLine("Blackforest Flovour");
        }
    }
    class CakePorlour
    {
        static void Main(string[] args)
        {
            Strawberry s = new Strawberry();
            Blackforest b = new Blackforest();
            s.bake();
            b.bake();
        }
    }
}
