using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applied_learning_assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ERICA SOMMER SPRING 2016 COHORT

            /* Create a program that asks the user to enter an integer. If the 
            integer is less than 10, print the message "This number is too 
            small". If the integer is greater than or equal to 10, print "This 
            number is big enough".   */

            Console.WriteLine("Please enter an integer.");
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine("This number is too small.");
            }
            else if (num >= 10)
            {
                Console.WriteLine("This number is big enough.");
            }

            /* Create a program that creates an array of five 
            hard-coded floating-point values, then prints out just the 
            second value. */

            float[] arrayValues = new float[] { 4.12f, 5.6f, 66f, 31f, 3.1416f };
            Console.WriteLine(arrayValues[1]);  //print second value (index 1)

            /*Modify the above program so that it uses a foreach loop to 
            display all the values in the array, all on one line. */

            foreach (float val in arrayValues) // use float so decimals print
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            /* Write a program that asks the user to enter  integer. If the 
            user enters '1', print "Only one?". If the user enters '100', 
            print "100? That's a lot!". If the user enters something other 
            than these two numbers, print "Input not recognized.".  The program 
            should use a switch statement. */

            Console.WriteLine("Please enter an integer.");
            int numQ4 = int.Parse(Console.ReadLine());
            
            switch (numQ4)
            {
                case 1:
                    Console.WriteLine("Only one?");
                    break;
                case 100:
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:
                    Console.WriteLine("Input not recognized.");
                    break;
              
            }

        }
    }
}
