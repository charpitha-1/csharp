using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    internal class StuMarks
    {
        private int[] marks = new int[10];
        public void AddMark(int mark,int Srno)
        {
            marks[Srno] = mark;
        }
        public int GetMarks(int Srno)
        {
            return marks[Srno];
        }
        public int[] GetAllMarks() { 
            return marks; 
        }
    }
}
