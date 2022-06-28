using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ShauryaTraining.Day3
{
    class DemoArrayList
    {

        
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();

            obj.Add(20);
            obj.Add(60);
            obj.Add("Ajinkya");
            obj.Add(900);
            obj.Insert(0,"Bangar"); //insert on 0 position
            obj.RemoveAt(4); //removing 900
            obj.Remove(60);//remove 60
            obj[1] = "Ajinkya"; //replace

            string s = (string)obj[1];
            Console.WriteLine(s.ToUpper());

            Console.WriteLine("Capacity is : " + obj.Capacity);
            Console.WriteLine("Count is : " + obj.Count);
            
            

            Console.WriteLine("/////////////////////**************/////////////");

            foreach(object c in obj)
            {
                Console.WriteLine(c);
            }

        }
    }
}
