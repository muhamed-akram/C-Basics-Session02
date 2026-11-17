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
            Console.WriteLine(obj.ToString() + "\n" 
                + obj.GetType() + "\n" 
                + obj.Equals(obj) +" \n"
                + obj.GetHashCode());

            #endregion
            #region Question 3
            //int pages = "464";// it's compile time error
            //int pages = 464;

            #endregion

        }



    }
}
