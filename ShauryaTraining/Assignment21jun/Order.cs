using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class Order
    {
        int orderd;
        string orderdate;
        Customer cust;
        Item ite;
        public int Orderd
        {
            get;
            set;
        }
        public string Orderdate
        {
            get;
            set;
        }
        public Customer Cust
        {
            get;
            set;
        }
        public Item Ite
        {
            get;
            set;
        }


        static void Main(string[] args)
        {
            Order or = new Order();
            or.Orderd =101;
            or.Orderdate = "23/06/2022";
            Customer c = new Customer();
            or.cust = c;
            or.cust.Custid = 112;
            or.cust.Custname = "Priya";
            Address a = new Address();
            c.Add = a;
            c.Add.Addr1 = "Prabhat Roead";
            c.Add.City = "Pune";
            c.Add.Pincode = 411001;

            Item i = new Item();
            or.ite = i;
            or.ite.Itemid = 202;
            or.ite.Itemname = "Shoes";
            or.ite.Price = 3000;
            Console.WriteLine("Order ID : " + or.Orderd);
            Console.WriteLine("Order Date : " + or.Orderdate);
            Console.WriteLine("Custome ID : " + or.cust.Custid);
            Console.WriteLine("Customer Name : " + or.cust.Custname);
            Console.WriteLine("Address : ");
            Console.WriteLine("Address 1 : " + c.Add.Addr1);
            Console.WriteLine("City : " + c.Add.City);
            Console.WriteLine("Pincode : " + c.Add.Pincode);

        }
    }
    class Customer
    {
        int custid;
        string custname;
        Address add;

        public int Custid
        {
            get;
            set;
        }
        public string Custname
        {
            get;
            set;
        }
        public Address Add
        {
            get;
            set;
        }


    }


    
    class Address
    {
        string addr1,city;
        int pincode;
        
        public string Addr1
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;

        }
        public int Pincode
        {
            get;
            set;
        }
    }
    class Item
    {
        int itemid;
        string itemname;
        int price;

        public int Itemid
        {
            get;
            set;
        }
        public string Itemname
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
    }
}
