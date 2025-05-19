using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiViewConsole1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueInput val = new ValueInput();
            BarChart barChart = new BarChart();
            LineChart lineChart = new LineChart();
            val.ValueAdded += barChart.OnValueAdded;
            val.ValueAdded += lineChart.OnValueAdded;
            val.AddData();
        }
    }
}
