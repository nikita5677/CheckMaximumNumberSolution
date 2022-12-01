using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChechMaximumNumber
{
    public class GenricMaximum<T> where T : IComparable
    {
        public T[] value;
        /// <summary>
        /// This method is created for initialize the constructor of instance variables
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        public GenricMaximum(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// This method is created for sorting the values
        /// </summary>
        /// <param name="values"></param>
        /// <returns>sortedValues</returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// This method is created for finding max for given type
        /// param is used for optional
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[1];
        }
        /// <summary>
        /// This method is created calling maxvalue method
        /// </summary>
        /// <returns>max</returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        /// <summary>
        /// This method is printing maximum genric value
        /// </summary>
        /// <param name="values"></param>
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
