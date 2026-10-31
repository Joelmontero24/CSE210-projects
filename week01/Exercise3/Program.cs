using System;
class Program
{
    static void Main(string[] args)
    {

        //Part #1
        // asking the user for the magic number. 
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        
        //Console.Write("What is your guess? ");
       //int guess = int.Parse(Console.ReadLine());

       // if (magicNumber > guess)
        //{
          //   Console.WriteLine("Higher");
       // }
        //else if (magicNumber < guess)
        //{
         //   Console.WriteLine("Lower");
       // }
       // else
       // {
         //    Console.WriteLine("You guessed it!");
        //}


        // Instead of having the user supply the magic number, generate a random number
        // from 1 to 100.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
    
    
        int guess = -1;

      while (guess != magicNumber)
      {
          Console.Write("What is your guess? ");
          guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
             Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
                Console.WriteLine("Lower");
        }
        else
        {
                Console.WriteLine("You guessed it!");
        }

      }
    }
}