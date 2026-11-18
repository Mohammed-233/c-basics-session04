using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    internal class Program
    {
        #region Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
       static void PrintWelcomeMessage() 
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion
        #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
        static void PrintBookTitle(string title) 
        {
            Console.WriteLine("Book title: " + title);
        }
        #endregion
        #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
        static int AddBonusPages(int pages)
        {
            pages += 50;
            return pages;
        }
        #endregion
        #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect tosee, and why?
      static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        #endregion
        #region Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
       static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;

        }
        #endregion
        #region Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Lengthafterward.
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion
        #region Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        #endregion
        #region Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }
        #endregion
# region Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.
        static void PrintBookInfoEdit(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }
        #endregion
        #region Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.
        static void PrintAllTitles(params string[] titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] sgelfCopies = {
            //    { 3, 5 }
            //    ,{ 1, 4 } 
            //};
            //Console.WriteLine(sgelfCopies[1, 0]);
            #endregion
            #region Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion

            #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            //PrintBookTitle("Clean Code");
            #endregion
            #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //Console.WriteLine(pages);
            //Console.WriteLine(AddBonusPages(pages));
            #endregion
            #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect tosee, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //because arrays are reference types, the original array is modified when passed to the method, so prices[0] will be 20.5 after the method call.
            #endregion
            #region Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
            //int pages = 500;
            //Console.WriteLine($"Before: {pages}");
            //AddBonusPagesByRef(ref pages);
            // Console.WriteLine($"After: {pages}");
            #endregion
            #region Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Lengthafterward.
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"Before: {prices.Length}");
            //ReplaceArray(ref prices);
            //Console.WriteLine($"After: {prices.Length}");

            #endregion
            #region Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //double cleanCodePrice;


            //if (TryGetPrice("Clean Code", out cleanCodePrice))
            //{
            //    Console.WriteLine(cleanCodePrice); // هيطبع 25.5
            //}
            //else
            //{
            //    Console.WriteLine(cleanCodePrice); // هيطبع 0
            //}
            #endregion
            #region Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.

            //PrintBookInfo(title:"Ahmed"); // Call with only title
            //PrintBookInfo(title:"Ahmed",pages:1000); // Call with only title
            #endregion
            #region Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.
            //PrintBookInfoEdit(pages: 1000, title: "Ahmed");
            #endregion
            #region Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.
            //string[] titles = { "Book 1", "Book 2", "Book 3" };
            //PrintAllTitles(titles);
            #endregion


        }
    }
}
