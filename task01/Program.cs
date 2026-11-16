using System.Drawing;

namespace task01
{
    internal class Program
    {
        #region Question 1 
        //Q01.  Create a Book class with a Title (string) and Pages (int).
        //Create a Book object and store it in a
       // variable of type object. Print it.
        class Book
        {
            public string Title;
            public int Pages;
        }
      

        static void Main(string[] args)
        {
            Book obj = new Book();
            obj.Title = "How to Program c#";
            obj.Pages = 1018;

            Console.WriteLine(obj.Title + "\n" + obj.Pages);
        } 
        #endregion
    }
}
