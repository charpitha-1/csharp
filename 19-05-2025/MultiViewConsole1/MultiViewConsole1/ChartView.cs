using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiViewConsole1
{
    public  abstract class ChartView
    {
        public abstract void UpdateView();
       
    }
    public class LineChart : ChartView
    {
        public override void UpdateView()
        {
            Console.WriteLine("Drawing LineChart");
        }
        public void OnValueAdded()
        {
            Console.WriteLine("Drawing a Line chart");
        }
    }
    public class BarChart : ChartView
    {
        public override void UpdateView()
        {
            Console.WriteLine("Drawing BarChart");
        }
        public void OnValueAdded()
        {
            Console.WriteLine("Drawing Bar chart");
        }
    }


}