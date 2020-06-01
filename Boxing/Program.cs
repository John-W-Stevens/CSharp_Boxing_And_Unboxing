using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty List of type object
            List<object> BoxedData = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair"
            BoxedData.Add(7);
            BoxedData.Add(28);
            BoxedData.Add(-1);
            BoxedData.Add(true);
            BoxedData.Add("chair");

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (var Value in BoxedData)
            {
                Console.WriteLine(Value);
            }

            // Add all values that are Int type together and output the sum
            int Sum = 0;
            foreach (var Value in BoxedData)
            {
                if (Value is int)
                {
                    int ExplicitValue = (int)Value;
                    Sum += ExplicitValue;
                }
            }
            Console.WriteLine(Sum); // Output -> 34 (28 + 7 - 1 = 34)
        }
    }
}
