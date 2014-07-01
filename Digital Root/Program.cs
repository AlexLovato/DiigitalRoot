using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {//call the digital root function with a number
            Console.WriteLine(DigitalRoot("12345"));
            Console.ReadKey();
        }
        static int DigitalRoot(string input)
        {
            //make a temp integer
            int totalFinal = 0;
            //write original
            Console.WriteLine("original: " + input);
            //change the string to int
            int inputInt = int.Parse(input);
            //while we haven't reduced it down and there is still adding to be done
            while (input.Length > 1)
            {
                //make a total variable
                int total = 0;
                //add each number to the previous set of added 
                foreach (char a in input)
                {
                    //convert each car to string
                    string atemp = a.ToString();
                    //convert each string to int
                   int tempi = int.Parse(atemp);
                    //add each int to total 
                   total += tempi;
                    //put that value into inputInt
                   inputInt = total;
                    //Put that value into total Final to use it outside the loop
                   totalFinal = inputInt;
                    //Put inputInt back to input as a string to be used in the next loop (if there is one)
                   input = inputInt.ToString();
                }

            }
            //return the final number, only after there is no more adding (the number has been reduced to one digit - the root)
 return totalFinal;
        }
    }
}
