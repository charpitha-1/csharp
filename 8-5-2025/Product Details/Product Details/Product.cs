using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details
{
    public  class Product
    {
        string name;
        string category;//string category="electronics";
        double price;
        //int qty;
        public int qty { get; set; } //auto implemented property

        public string PrName
        {
            get { return name; }
            set { name = value; }
        }
        public double PPrice
        {
            get { return price; }
            set { price = value; }
        }
        public string pCategory
        {
            get { return category; }
            set { category = value; }
        }
        public Product(string nm, string ctg, double pr,int quantity) 
        {
            name = nm;
            category = ctg;
            price = pr;
            qty = quantity;
        }
        public Product(string nm,string ctg,double pr) : this(nm, ctg, pr, 10)
        {

        }
        public void DisplayInfo() //public method
        {
            Console.WriteLine($"{name} ={price}={qty}");
        }

        public double CalCDiscount(string MembershipType)
        {
            double discount = CalCDiscount();
            if (MembershipType == "Silver")
            {
                discount = discount * 1.1;
            }
            else if (MembershipType == "Gold")
            {
                discount = discount * 1.2;
            }
            return discount;
        }
        public double CalCDiscount()
        {
            double discount = 0;
            if (qty > 1000 && qty < 1500)
            {
                if (qty == 2)
                {
                    discount = price * qty * 5 / 100.0;
                }
                else if (qty > 2)
                {
                    discount = price * qty * 10 / 100.0;
                }
            }
            else if (qty >= 1500 && qty < 2000)
            {
                if (qty == 2)
                {
                    discount = price * qty * 7.5 / 100.0;
                }
                else if (qty > 2)
                {
                    discount = price * qty * 15 / 100.0;
                }
            }
            else if (price >= 2000)
            {
                discount = price * qty * 20 / 100.0;
            }
            return discount;
        }
        //~Product()
        //{
        //    Console.WriteLine("from Destru");
        //}
    }
}
