using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiViewConsole1
{
    public delegate void ValueAddDelegate();
    

    public class ValueInput
    {
       // List<ChartView> chartViews=new List<ChartView>();
        public event ValueAddDelegate ValueAdded; //value added is a event name
        //BarChart barChart = new BarChart();
        //LineChart lineChart = new LineChart();
        public ValueInput() {
            //chartViews.Add(new LineChart());
            //chartViews.Add(new BarChart());
            //ValueAdded += barChart.OnValueAdded;
            //ValueAdded += lineChart.OnValueAdded;

        }
        public void AddData()
        {
            Console.WriteLine("New value Added");
            //foreach (ChartView c in chartViews)
            //{
            //    c.UpdateView();
            //}
            if(ValueAdded != null) //subscribers are available
            {
                ValueAdded();//raise event
            }
        }
    }
}
