using System;
using System.Collections.Generic;


// importing the class I wrote for KelvinToCelsius so I can use that class in my UI logic file


using TemperatureConverter.Models;
class Program
{
    static void Main()
    {

        // My appliction can perform 2 features; one is converting fahrenheit Temperature to celsius and vis a vis(vice-versa)
        // and the other is converting a temperature n Kelvin to celsius and vis a vis(vice-versa)
        Console.WriteLine("Welcome to the Temperature-Converter App made by Dynasty");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Input 'F' to supply in a fahrenheit temperature and our app converts it to Celsius");
        Console.WriteLine("Or input 'K' to supply in a Kelvin temperature and our app converts it to Celsius :)");

        string userStarts = Console.ReadLine().ToUpper();

        if (userStarts == "F")
        {

        }
        else if (userStarts == "K")
        {
              Console.WriteLine("You selected the option for a conversion of Kelvin to Celsius");
              Console.WriteLine();

            Console.WriteLine("Would you like to proceed('YES' or 'NO')");
            string userProceed = Console.ReadLine().ToUpper();

            if(userProceed == "YES")
            {
                ConvertKelvinValueToCelsius();
            }

            // The first UI logic method to write will be on picking up a Kelvin temperature and converting it to a 
            // celsius temperature 

            static void ConvertKelvinValueToCelsius(KelvinToCelsius kel)
            {

              
                Console.WriteLine();
                Console.WriteLine("Please enter in the kelvin value");
                string kelvinValue = Console.ReadLine();

                // converting that string into a integer

                int kelvinValueInt = int.Parse(kelvinValue);

                Console.WriteLine(kelvinValueInt);


                // the Convert To Temperature method here is from my Kelvin to tcelsius Temperature C# file


                // if (kelvinValueInt < 0)
                // {
                //     throw new ArgumentException("Invalid temperature in kelvin");
                // }

                // else
                // {
                //     string result = kel.KelConverterMethod(kelvinValueInt);

                //     int kelvinTemp = -273;
                //     // int celsiusValue = kelvinStandardValue - 273;
                //     // return kelvinTemp;
                // }

                // }

                // public int KelConverterMethod(int kelvinStandardValue)
                // {
                //     // NOTE: a C# method must always return something otherwise it gives the "not all code paths return a value error"

                //     if(kelvinStandardValue < 0)
                //     {
                //         throw new ArgumentException("Invalid temperature in kelvin");
                //     }

                //     else{
                //         int kelvinTemp = - 273;
                //         // int celsiusValue = kelvinStandardValue - 273;
                //         return kelvinTemp;
                //     }
                // }




            }





        }

        else
        {
            Console.WriteLine("I am sorry, I didn't get that; Please try again");
            Main();
        }

    }
}