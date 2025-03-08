using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //Create a List called "numbers" - DONE!
              //DO NOT ERASE THIS! You will use this in the exercise.
              var numbers = new List<int>();
            
            //TODO - Create a variable of type int and name it "num"
            //TODO - Initialize the variable with a value of 0
            
            



            //TODO - Create a do-while loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1
            // b) Then add "num" to the collection "numbers"
            //    Hint: Use "numbers.Add(num);" to add the current value of "num" to the list.

            var num = 0; 
            do
            {
                num++;
                numbers.Add(num);

            } while ( num < 100 );
                

           

            
           
                    

                
            
            
            //TODO - Continue the loop while "num" is less than 100
            

            //TODO - Create a while loop using the existing brackets as a template.
            //TODO - Continue the loop while "num" is less than 200
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1
            // b) Then add "num" to the collection "numbers"
            //    Hint: You can copy how this was done in the do-while loop

            

            while(num < 200) 
            {
                num++;
                numbers.Add(num);

            }



            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            //TODO - Create a foreach loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop, print each number in "numbers".
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            
            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            //TODO - Create a for loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // This loop will print the numbers in reverse order - from 200 to 1.

            // a) In your initializer, set the value of "i" to 199
            // b) In your conditional, ensure that the loop continues as long as "i" is:
            //    - Less than or equal to the number of items in "numbers" (use "numbers.Count")
            //    - Greater than or equal to 0
            // c) Decrement "i" by 1 in each iteration

            for (int k = 199; k <= numbers.Count && k >= 0; k--)
            { 
                Console.WriteLine(numbers[k]);
            }
            

            //------------End of exercise

        }
    }
}
