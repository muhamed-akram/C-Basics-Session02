using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace task01
{
    internal class Program
    {
        #region Question 1 
        //Q01.Create a Book class with a Title(string) and Pages(int).
        //Create a Book object and store it in a
        // variable of type object.Print it.
        class Book
        {
            public string Title;
            public int Pages;
        }
        #endregion

        static void Main(string[] args)
        {
            //this related to Question1
            Book obj = new Book();//question1
            obj.Title = "How to Program c#";//question1
            obj.Pages = 1018;//question1
            Console.WriteLine(obj.Title + "\n" + obj.Pages);//question1

            #region Question2
            //Using the Book class above, print the result of calling ToString(), Equals()
            //(compare book with itself), GetHashCode(), and GetType() on book.
            Console.WriteLine(obj.ToString() + "\n" 
                + obj.GetType() + "\n" 
                + obj.Equals(obj) +" \n"
                + obj.GetHashCode());

            #endregion
            #region Question 3
            //  Look at the line below. Is it a compile-time error, a runtime error, or a logical error?
            //  Fix it .int pages = "464";
            //int pages = "464";// it's compile time error
            //int pages = 464;

            #endregion
            #region Question 4
            //  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block

            //try
            //{
            //    int y = 0;
            //    int x = 10 / y;
            //}catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Question 5
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            //int Pages = 300;
            //Double pages = Pages;
            #endregion
            #region Question 6
            // Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int x = (int)price;
            #endregion
            #region Question 7
            // Given string pagesText = "464";, convert it into an int using the Convert class
            //string pagesText = "464";
            //int number = Convert.ToInt32(pagesText);
            #endregion
            #region Question 8
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            // use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";
            if(int.TryParse(badText, out int result))
                Console.WriteLine($"Parsed:{result}");
            
            else
                Console.WriteLine("Invalid");
            #endregion
            #region Queestion 9
            // Given int pages = 464;,
            // convert it into a string using ToString() and print its type using GetType()
            // to prove it's now a string

            int pages = 464;
            string y = pages.ToString();
            Console.WriteLine(y.GetType());

            #endregion
            #region Question 10
            //  Declare int copies = 100;. Box it into an object variable,
            //  then unbox it back into a new int
            //variable, and print both
            int copies = 100;
            object obj2 = copies;

            int number = (int)obj2;
            #endregion
            #region Question 11
            // Declare an int? year = null;
            // . Print whether it has a value,
            // then assign it 2023 and print its value
            int? year1 = null;
            Console.WriteLine(year1.HasValue);
            year1 = 2023;
            Console.WriteLine(year1);
            #endregion
            #region Question 12
            // Declare a string? reviewer = null;. Print whether it is null.
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            #endregion
            #region Question 13
            // Declare a Book? book = null;. Use ?. to safely read
            // book.Title without crashing the program, and
            // print the result.
            Book? book = null;
            string? t = book?.Title;
            Console.WriteLine(t);

            #endregion

        }



    }
}
