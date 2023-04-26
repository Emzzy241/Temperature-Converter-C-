using System;
using System.Collections.Generic;


// importing the class I wrote for KelvinToCelsius so I can use that class in my UI logic file


using TemperatureConverter.Models;
class Program{
    static void Main(){

        // My appliction can perform 2 features; one is converting fahrenheit Temperature to celsius and vis a vis(vice-versa)
        // and the other is converting a temperature n Kelvin to celsius and vis a vis(vice-versa)
        Console.WriteLine("Welcome to the Temperature-Converter App made by Dynasty");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Input 'F' to supply in a fahrenheit temperature and our app converts it to Celsius");
        Console.WriteLine("Or input 'K' to supply in a Kelvin temperature and our app converts it to Celsius :)");

        string userStarts = Console.ReadLine().ToUpper();

        if(userStarts == "F")
        {

        }
        else if(userStarts == "K")
        {
            Console.WriteLine("You selected the option for a conversion of Kelvin to Celsius");
            Console.WriteLine();
            Console.WriteLine("Please enter in the kelvin value");
            string kelvinValue = Console.ReadLine();



        // The first UI logic method to write will be on picking up a Kelvin temperature and converting it to a 
        // celsius temperature 

        // static void ConvertKelvinValueToCelsius(KelvinToCelsius kel)
        // {
        //     // the Convert To Temperature method here is from my Kelvin to tcelsius Temperature C# file

        //     string result = kel.ConvertTemperature();

        // }




        }
        else{
            Console.WriteLine("I am sorry, I didn't get that; Please try again");
            Main();
        }



        

    }
}