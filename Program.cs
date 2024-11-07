using System.Formats.Asn1;
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
      
      Answer:
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

      /*
      3. Write a C# Sharp program that takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected.

      Answer:
      // stored UN/PW
      string storedUsername = "WesleyMatta";
      string storedPassword = "wm1234";

      // while loop get user input and check against stored values
      // count failures then return rejection
      int loginAttempts = 0;

      while (true)
      {
        Console.WriteLine("Username:");
        string inputUsername = Console.ReadLine();
        Console.WriteLine("Password:");
        string inputPassword = Console.ReadLine();
        
        if (loginAttempts == 2)
        {
          Console.WriteLine("You have been locked out");
          break;
        }

        if (inputUsername == storedUsername && inputPassword == storedPassword)
        {
          Console.WriteLine("Successfully logged in!");
          break;
        }
        else
        {
          Console.WriteLine("Incorrect UN or PW...");
          loginAttempts++;
          continue;
        }
      }
      */

      /*
      4. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.

      Test Data
      Input first number: 20
      Input operation: -
      Input second number: 12
      Expected Output :
      20 - 12 = 8
      
      Answer:
      int inputFirstNum, inputSecondNum;
      string inputOperation;
      Console.WriteLine("Input first number:");
      inputFirstNum = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input an operation:");
      inputOperation = Convert.ToString(Console.ReadLine());
      Console.WriteLine("Input second number:");
      inputSecondNum = Convert.ToInt32(Console.ReadLine());

      if (inputOperation == "+")
      {
        int answer = inputFirstNum + inputSecondNum;
        Console.WriteLine($"{inputFirstNum} + {inputSecondNum} = {answer}");
      }
      else if (inputOperation == "-")
      {
        int answer = inputFirstNum - inputSecondNum;
        Console.WriteLine($"{inputFirstNum} - {inputSecondNum} = {answer}");
      }
      else if (inputOperation == "*" ||  inputOperation == "x")
      {
        int answer = inputFirstNum * inputSecondNum;
        Console.WriteLine($"{inputFirstNum} * {inputSecondNum} = {answer}");
      }
      else if (inputOperation == "/")
      {
        int answer = inputFirstNum / inputSecondNum;
        Console.WriteLine($"{inputFirstNum} / {inputSecondNum} = {answer}");
      }                  
      */

      /*
      5. Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
      a = πr^2
      p = 2πr
      Test Data
      Input the radius of the circle :
      12
      Expected Output :
      Perimeter of Circle : 75.398
      Area : 452.389

      Answer:
      Console.WriteLine("Input a radius: ");
      double inputRadius = Convert.ToDouble(Console.ReadLine());
      
      double circleArea = Math.PI * inputRadius * inputRadius;
      double circlePerimeter = 2 * Math.PI * inputRadius;

      Console.WriteLine($"Area: {circleArea}, Perimeter: {circlePerimeter}");
      */

    }
  }
}