using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Array
{
    public class ArrayListUsingGenericClass<T>
    {
        public T[] inputArray;
        public ArrayListUsingGenericClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}