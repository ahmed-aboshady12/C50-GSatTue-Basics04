using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Q02
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies =
            //{
            //    {3, 5},
            //    {1, 4}
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region Q03
            //Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion
            #region Q04
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with "Clean Code".
            //void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}
            //PrintBookTitle("Clean Code");
            #endregion
            #region Q05
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            //void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // اتوقع يطبع 400 لانه احنا مرجعناش ليه قيمه لانه void  لو عايز يرجع نخليه int 
            #endregion
            #region Q06
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?
            //void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //}
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // مش هيتغير لانه مرجعناش قيمه
            #endregion
            #region Q07
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
            //void AddBonusPagesByRef(ref int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            //هيزيد 50
            #endregion
            #region Q08
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.
            //void ReplaceArray(ref double[] prices)
            //{
            //    prices =new double[]{ 10.0, 12.5, 15.0 };
            //}
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion
            #region Q09
            //Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it 2 and print the price if found

            //bool TryGetPrice(string title, out double price)
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    price = 0;
            //    return false;
            //}
            //TryGetPrice("Clean Code", out double price);
            //Console.WriteLine(price);
            #endregion
            #region Q10
            //Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call it once with only a title, and once passing both a title and pages
            void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine($"Book: {title}, Pages: {pages}");
            }
            PrintBookInfo("Clean Code");
            #endregion
        }
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
    }
}
