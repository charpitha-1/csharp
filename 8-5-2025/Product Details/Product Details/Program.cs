using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product count in order");
            int nProductCount=int.Parse(Console.ReadLine());
            Order order = new Order("002", "2023-4-6", "kurnool", nProductCount);
            int nP = 0;
            if(nProductCount>0)
            {
                bool Success=false;
                do
                {
                    Console.WriteLine($"Enter the Product Number :{nP}");
                    Console.WriteLine("Enter the Product Name");
                    string PName = Console.ReadLine();
                    Console.WriteLine("Enter the Product Category");
                    string PCategory = Console.ReadLine();
                    Console.WriteLine("Enter the Product price");
                    double Price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Qty");
                    int Qty = int.Parse(Console.ReadLine());

                    Product prod1 = new Product(PName, PCategory, Price);
                    Success =order.AddProduct(prod1);
                    ++nP;
                } while(nP<nProductCount);
            }
            order.ShowOderProducts();
            
            /* Console.WriteLine("Enter the Product Name");
            string PName=Console.ReadLine();
            Console.WriteLine("Enter the Product Category");
            string PCategory=Console.ReadLine();
            Console.WriteLine("Enter the Product price");
            double Price=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Qty");
            int Qty = int.Parse(Console.ReadLine());
            Product prod1=new Product(PName,PCategory,Price);*/
            //prod1.PrName= PName;
            //prod1.PPrice = Price;
            //prod1.pCategory = PCategory;
            //prod1.qty= Qty;
            //prod1.DisplayInfo();
            //int qty = 2;
            //Console.WriteLine("Qty given:"+qty);
            //Console.WriteLine("defined category: " + prod1.PCategory);
            //double ordDiscount = prod1.CalCDiscount();
            //Console.WriteLine($"without MemembershipType:{ordDiscount}");
            //double ordDiscount2 = prod1.CalCDiscount("Gold");
            //Console.WriteLine($"without MemembershipType:{ordDiscount2}");
            //prod1 = null;

            //Product prod2 = new Product();
            //prod2.PrName = "p2name";
            //prod2.PPrice = 2464.2;
            //prod2.DisplayInfo();

            //   public double CalCDiscount() 
            //{
            //    double discount = 0;
            //    if (qty > 1000 && qty < 1500)
            //    {
            //        if (qty == 2)
            //        {
            //            discount = price * qty * 5 / 100.0;
            //        }
            //        else if (qty > 2)
            //        {
            //            discount = price * qty * 10 / 100.0;
            //        }
            //    }
            //    else if (qty >= 1500 && qty < 2000)
            //    {
            //        if (qty == 2)
            //        {
            //            discount = price * qty * 7.5 / 100.0;
            //        }
            //        else if (qty > 2)
            //        {
            //            discount = price * qty * 15 / 100.0;
            //        }
            //    }
            //    else if (price <= 2000)
            //    {
            //        discount = price * qty * 20 / 100.0;
            //    }
            //    return discount;
            //   // Console.WriteLine("discount: " + discount);
            //}
        }
    }
}
