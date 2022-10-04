namespace RandomNumberGenerator
{
    using RandomNumberGenerator.Classes;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {

            int[] newArray = Enumerable.Range(1, 10000).ToArray();
            foreach(int num in newArray)
            { Console.WriteLine(num); }
        
            //var randomList = RandNumberGenerator.CreateRandomList(newArray);

            ////Debug.Assert(randomList.Length == listSize);
            ////Debug.Assert(randomList.Distinct().Count() == randomList.Count);

            //RandNumberGenerator.PrintList(randomList);
        }
    }
}