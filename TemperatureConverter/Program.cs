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
        Console.WriteLine();
        Console.WriteLine("Input 'K' to supply in a Celsius temperature and our app converts it to Fahrenheit");
        Console.WriteLine();
        Console.WriteLine("Or input 'K' to supply in a Kelvin temperature and our app converts it to Celsius :)");
        Console.WriteLine();
        Console.WriteLine("Or input 'KK' to supply in a Celsius temperature and our app converts it to Kelvin :)");

        string userStarts = Console.ReadLine().ToUpper();

        if (userStarts == "F")
        {

        }
        else if (userStarts == "K")
        {
            Console.WriteLine("You selected the option for a conversion of Kelvin to Celsius");
            Console.WriteLine("We'll help you convert a Kelvin Temperature into a celsius one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the kelvin value");
            string kelvinValue = Console.ReadLine();

            // converting that string into a integer

            int kelvinValueInt = int.Parse(kelvinValue);

            Console.WriteLine(kelvinValueInt);

            double celsiusStandard = -273.15;

            // instantiating a new KelvinToCelsius object so I can store user's value in it

            KelvinToCelsius kel = new KelvinToCelsius(kelvinValueInt, celsiusStandard);

            // running a method to confirm or edit the value my user enterred for kelvin

            ConfirmOrEditKelvin(kel);

            static void ConfirmOrEditKelvin(KelvinToCelsius confirmKel)
            {
                Console.WriteLine("Please confirm that you enterred the correct value for your triangle");

                // here is where I used my getter to get user information on their kelvin value
                // so they can choose to use my setter to set information on their kelvin value or not
                Console.WriteLine($"You enterred {confirmKel.ConvertingCelsiusToKelvin} for the kelvin value");
                Console.WriteLine();
                Console.WriteLine("Is that correct, enter 'yes' to continue or 'no' to change that value");
                string userAns = Console.ReadLine().ToUpper();

                // using a switch-case here
                switch (userAns)
                {
                    case "YES":
                        Console.WriteLine("Great, Lets move on");
                        ConvertKelvinValueToCelsius(confirmKel);
                        break;
                    case "NO":
                        Console.WriteLine("Lets fix up your kelvin value");
                        Console.WriteLine("Enter a new value for your kelvin temperature");
                        string newKelvinValue = Console.ReadLine();
                        double newKelvinValueInt = double.Parse(newKelvinValue);

                        double newCelsiusStandard = -273.15;

                        // no need to reinstantiate an instnace of my KelvinTOCelsius class, I have a setter property in it that can achieve that for me
                        // saving it up; and I used confirmKel this time around because thats the kelvinToCelsius object I instantiated for this method
                        confirmKel.ConvertingKelvinToCelsius = newKelvinValueInt;
                        confirmKel.ConvertingCelsiusToKelvin = newCelsiusStandard;


                        // Now inside our method, we run our method again so it keeps confirming if the kelvin value of my user is correct
                        // what we did here is looping, we keep asking our users questions on whether a certain value is correct before they proceed
                        // Again, the concept of calling methodA inside methodA is known as looping

                        ConfirmOrEditKelvin(confirmKel);

                        break;
                    // Always remember to add these break statements in a switch-case block so it knows you are donw with that case


                    default:
                        Console.WriteLine("Sorry I didnt get that");
                        Main();
                        break;
                }

            }


            // Console.WriteLine("Would you like to proceed('YES' or 'NO')");
            // string userProceed = Console.ReadLine().ToUpper();





            // if (userProceed == "YES")
            // {
            //     ConvertKelvinValueToCelsius();
            // }
            // else if (userProceed == "NO")
            // {
            //     Main();
            // }
            // else
            // {
            //     Console.WriteLine("Sorry, I didn't get that, lets try again");
            //     Main();
            // }

            // The first UI logic method to write will be on picking up a Kelvin temperature and converting it to a 
            // celsius temperature 

            static void ConvertKelvinValueToCelsius(KelvinToCelsius finalKel)
            {
                double userKelvinValue = finalKel.ConvertingCelsiusToKelvin;
                double standardCelsiusValue = finalKel.ConvertingKelvinToCelsius;


                double result = finalKel.KelConverterMethod();

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Your result is {result}C");
                // tri.Add(result);

                Console.WriteLine("--------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Yay, you now have your Temperature value in Celsius");
                Console.WriteLine("What's next?");
                Console.WriteLine("Would you like to convert a new kelvin temperature (new)?");
                Console.WriteLine();
                Console.WriteLine("Please enter 'new' to convert a new kelvin temperature, enter 'get' to get all kelvin temperatures you've converted. To exit, enter X.");
                string userContinue = Console.ReadLine().ToUpper();
                
                switch (userContinue)
                {
                    case "NEW":
                        Main();
                        break;

                    case "GET":
                        // GetAllConvertedKelvins();
                        break;
                    case "X":
                        Console.WriteLine("Goodbye My dear User");
                        break;

                    
                    default:
                        Console.WriteLine("Sorry, I didn't get that; Lets try again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                        break;
                }



                Console.WriteLine();

            }





        }

        else
        {
            Console.WriteLine("I am sorry, I didn't get that; Please try again");
            Main();
        }

    }
}