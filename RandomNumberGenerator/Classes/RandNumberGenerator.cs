using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Classes
{
    public static class RandNumberGenerator
    {
        public static int[] CreateRandomList(int[] arr)
        {
            var rand = new Random();
            int last_index = arr.Length - 1;        
            while (last_index > 0)
            {             
                int rand_index = rand.Next(0, last_index);
                int temp = arr[last_index];
                arr[last_index] = arr[rand_index];
                arr[rand_index] = temp;
                last_index -= 1;
            }

            return arr;
        }

        public static void PrintList(int[] newArray)
        {
            Console.WriteLine("Randomized List \n");
            foreach (int item in newArray)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
