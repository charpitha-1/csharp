using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    internal class ProductPrice
    {
        public double[] prices=new double[4];
        public void AddPrice(double price,int sno)
        {
            prices[sno] = price;
        }
        public double GetPrice(int sno)
        {
            return prices[sno];     
        }
        public double[] GetAllPrices()
        {
            return prices;
        }
    }
}
