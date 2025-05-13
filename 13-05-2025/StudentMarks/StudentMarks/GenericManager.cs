using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    internal class GenericManager<T>where T:Employee///accept only ref type              //where T : struct //accept only value type
    {
        T[] Values=new T[5]; //Array of type t
        public void Add(T inp,int pos)
        {
            Values[pos] = inp;
        }
        public T GetValue(int pos)
        {
            return Values[pos];
        }
        public T[] GetAll()
        {
            return Values;
        }
        //public T Increment (int pos)
        //{
        //    return Values[pos]++; //Limitation ---type specific cannot
        //                            happen bcz all the data types willnot supports
        //                            ex--int can be incremented but string is not possible
        //}
        public string increment(int pos)
        {
            return Values[pos].GetName()+"   "+ Values[pos].id;
        }
    }
}
