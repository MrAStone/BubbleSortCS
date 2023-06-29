using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); // used for setting up the data
            int[] data = new int[1000]; //array to store 1000 (0-999) data items
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(1000, 100000); // add random numbers between 1000(inclusive) and 1000000(exclusive)
            }

            // Bubble Sort Algorithm

            bool swaps =true;
            int n = data.Length;
            while (swaps) // will only loop while swaps are happening
            {
                swaps = false; // set swaps to false, at the start of this pass, there are no swaps
                for(int i = 1; i < n; i++) // Pass i
                {
                    if (data[i - 1] > data[i])
                    {
                        // swapping array values
                        int temp = data[i]; 
                        data[i] = data[i - 1];
                        data[i - 1] = temp;
                        swaps = true;// if a swap took place, set to true so another pass is needed
                    }
                }
                n -= 1; //after each pass the last index is in the correct position, this goes down each pass
            }
            // print out the array
            for(int i = 0; i < data.Length;i++)
            {
                Console.Write(data[i] + " ");
            }

        }
    }
}
