using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string ShippingAddress {  get; set; }

        public Product[] Products { get; set; }//contains relation
        private int ArrIndex = 0;
        public Order(string onumber,string odate,string shipAddress,int NumberOfProducts) { 
            OrderNumber = onumber;
            OrderDate = odate;
            ShippingAddress = shipAddress;
            Products = new Product[NumberOfProducts];
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine($"{OrderNumber}--{OrderDate}--{ShippingAddress}");
        }

        public bool AddProduct(Product p)
        {
            if (ArrIndex >= Products.Length)
            {
                Console.WriteLine("Max Number Reached");
                return false;
            }
            else
            {
                Products[ArrIndex] = p;
                ++ArrIndex;
                return true;
            }
        }
        public void ShowOderProducts()
        {
            foreach(Product p in Products)
            {
                p.DisplayInfo(); //delegation
                double discount = p.CalCDiscount();
                Console.WriteLine($"Product discount:{discount}");
            }
        }
    }
}
