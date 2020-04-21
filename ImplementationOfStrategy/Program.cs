using ImplementationOfStrategy.SortingAlgorithms;
using System;
using System.Globalization;

namespace ImplementationOfStrategy
{ /// <summary>
  /// Entry point into console application.
  /// 
  /// Application's goals : 
  /// 
  ///   Let the user choose the sorting of t-shirts.
  ///   Use of the strategy design pattern.
  ///   Use of quick, bucket and bubble sort. 
  ///   Use of generics.
  ///   Use of delegates
  ///   
  /// The system lets the user sort the items, customise a t-shirt and calculates the t-shirt's price according to its variations.Last;y, it lets the customer pay depending on his/hers chosen payment method.
  /// 
  /// Eleni Parisi
  /// Instructor: Hektor Gatsos
  /// 
  /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Greek globalization system

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("gr-GR");

            //This menu will allow you to choose the way you want to sort the t-shirts. 
            //TIP: Bubble sort has extra features: the simultaneous sort of the 3 variations. 

            Print.SortingMenu();

            //This method will allow you to customise a T-shirt, and pay for it with your chosen method.

            Print.CustomTshirtMenu();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Thank you for choosing our e-shop!");
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
