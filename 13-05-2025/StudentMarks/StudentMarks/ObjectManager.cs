using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    internal class ObjectManager
    {
        private Object[] objArray=new Object[4]; //object based class
        public void Add(Object obj,int pos) //boxing
        {
            objArray[pos]=obj;
        }
        public Object Get(int pos) {
            return objArray[pos];
        }
        public Object[] GetALl()
        {
            return objArray;
        }
    }
}
