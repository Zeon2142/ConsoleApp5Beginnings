using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            float numberofattempts = 0;
            string no = "no";
            string yes = "yes";
            string username = "Zeon2142";
            string password = "test";
            bool BLN;//true and false stuff

            Console.WriteLine("Hello and Welcome "+ "to Xerinx assistant desk");

            do

            {

                Console.WriteLine("Please Enter Your Username");
                string enteredusername = Console.ReadLine();//Read line = user input

                Console.WriteLine("Please Enter Your Password");
                string enteredpassword =  Console.ReadLine();//same as above read line just more special

                if (username == enteredusername && enteredpassword == password)
                {
                    Console.WriteLine("Welcome CEO Zeon");
                }
                else if ((enteredusername == no && enteredpassword == yes) || (enteredusername == yes && enteredpassword == no))
                {
                    Console.WriteLine("Welcome Moral Support Leader Justin");

                }
                else if ((enteredusername == no && enteredpassword == no) || (enteredusername == yes && enteredpassword == yes))
                {
                    Console.WriteLine("Welcome Moral Support Leader Justin");
                }
                else
                {
                    numberofattempts += 1;
                    if (numberofattempts == 3)
                    {
                        Console.WriteLine("No More Attempts!");
                    }
                    else
                    {

                        Console.WriteLine("Retry");
                    }
                }

            }
            while (numberofattempts < 3); 

            Console.ReadKey();//create first and put last


        }
    }
}