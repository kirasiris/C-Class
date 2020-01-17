using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");
            /*
             * 
             * String Example
             * 
             */
            //string greetings = "Welcome to TCCD.";
            //string lazy = "I want to go home, this class is boring";
            //Console.WriteLine(greetings);

            // greetings = "I want to go home, this class is boring";
            //Console.WriteLine(greetings+" "+lazy);
            /*
             * 
             * Char Example 
             * 
             */
            //Char Grade = 'A';

            //Console.WriteLine("Minimum value of Char is: "+Char.MinValue);
            //Console.WriteLine("Minimum value of Char is: " + Char.MaxValue);
            //Console.WriteLine("Minimum value of long is: " + long.MinValue);
            //Console.WriteLine("Minimum value of long is: " + long.MaxValue);
            //Console.WriteLine("Minimum value of int is: " + int.MinValue);
            //Console.WriteLine("Minimum value of int is: " + int.MaxValue);
            //Console.WriteLine("Minimum value of byte is: " + byte.MinValue);
            //Console.WriteLine("Minimum value of byte is: " + byte.MaxValue);
            //byte a = 5; // byte takes ONLY numbers greater than zero
            //sbyte b = -5; // sbyte takes any negative or positive number
            //Console.WriteLine(a+" "+b);
            //Console.WriteLine(Grade);
            /*
             * 
             * My first assignment 
             * 
             */
            string firstRow             = "|-------------------------------------------|\n";
            string myFullName           = "|   Kevin Uriel Azuara Fonseca              |\n";
            string myBirthDate          = "|   05/29/98                                |\n";
            string myJob                = "|   Help Desk Support Agent II              |\n";
            string myState              = "|   San Luis Potosi                         |\n";
            string myExpectation        = "|   Just get better in an existing skill?   |\n";
            string myFavoriteVideogame  = "|   Forza Horizon 4                         |\n";
            string lastRow              = "|-------------------------------------------|\n";
            Console.WriteLine(firstRow+myFullName+myBirthDate+myJob+myState+myExpectation+myFavoriteVideogame+lastRow);

            Console.ReadLine();
        }
    }
}
