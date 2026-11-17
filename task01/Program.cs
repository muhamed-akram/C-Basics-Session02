using System.ComponentModel.Design;
using System.Drawing;

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
        }



    }
}
