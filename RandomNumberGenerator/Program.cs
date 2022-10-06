namespace RandomNumberGenerator
{
    using RandomNumberGenerator.Classes;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = Enumerable.Range(1, 10000).ToArray();
            var randomList = RandNumberGenerator.CreateRandomList(newArray);
            RandNumberGenerator.PrintList(randomList);
        }
    }
}