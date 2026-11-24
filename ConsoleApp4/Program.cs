using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print the second price(index 1).
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion
        }
    }
}
