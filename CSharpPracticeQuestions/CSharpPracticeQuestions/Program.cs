using System.Globalization;
using System.Security.Cryptography.X509Certificates;


namespace PracticeQuestions
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      1. Write a C# Sharp program that takes three letters and displays them in reverse order.
      Test Data
      Enter letter: b
      Enter letter: a
      Enter letter: t
      
      Expected Output :
      t a b
      
      Answer:
      char firstLetter, secondLetter, thirdLetter;
      Console.WriteLine("Enter 1st Letter: ");
      firstLetter = Convert.ToChar(Console.ReadLine());
      Console.WriteLine("Enter 2nd Letter: ");
      secondLetter = Convert.ToChar(Console.ReadLine());
      Console.WriteLine("Enter 3rd Letter: ");
      thirdLetter = Convert.ToChar(Console.ReadLine());
      Console.WriteLine($"{thirdLetter} {secondLetter} {firstLetter}");
      */

      /*
      2. Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.
      Test Data
      Enter a number: 6
      Enter the desired width: 6
      Expected Output :

      666666                                                      
      66666                                                           
      6666                                                                  
      666                                                        
      66                                                                  
      6 
      
      Console.WriteLine("Enter a number: ");
      int numberPick = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter the width: ");
      int numberWidth = Convert.ToInt32(Console.ReadLine());

      do
      {
      Console.WriteLine($"{string.Concat(Enumerable.Repeat(numberPick, numberWidth))}");
      numberWidth--;
      }
      while (numberWidth != 0);
      */
    }
  }
}