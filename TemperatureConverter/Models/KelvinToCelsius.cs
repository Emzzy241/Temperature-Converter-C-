// This is the class  for the Conversion of a Kelvin Temperature into a Celsius Temperature

// Remember, I need to import some things first off to ensure my C# code has a smooth flow 
using System; 
// the above is not really needed yet in my code and thats why the color us faint

using System.Collections.Generic;  
//the above using statement is very much needed in my code as it allows me to make use of C# Arrays, lists, and even dictionaries
// If I had created a C# array, list or dictionary without this using statement I would have the error 
// The type or namespace name 'List<>' could not be found (are you missing a using directive or an assembly reference?) [TemperatureConverter]csharp(CS0246)
// This is a simple error and it can even be fixed via the Quick fix option


// And I am separating my classes into separate files to ensure my application is scalable and ensure I perform a good separation of concern

// A namespace is a grouping of related class based on their importanced or function.

namespace TemperatureConverter.Models
{
    // making my class a public one so it can be accessible anywhere in my application
    public class KelvinToCelsius
    {

        // first off I need a field and a C# field is just like a javascript property(remember when we call js properties we don't add in parenthesis() =, we just add a dot(.) to them and call them directly on an object)
        // later on I might be adding in a constructor though

        // here is my C# field
        private int _convertsCelsiusToKelvin;
        private int _convertsKelvinToCelsius;

        // now my C# field has been written, remember these are private fields and private fields cannot be accessed directly, they need getters and setters to access them
        // And now I can choose to write out an entire GetFieldName() and SetFieldName() methods but I won't do that; 
        // I would write properties for both my getter and setter instead
        // so the get and set will be written inside my C# property and here is how to write a C# property

        /*
        public int ConvertsCelsiusTempToKelvin
        {
            // this entirely is a C# property 
            get { return _convertsCelsiusToKelvin; }
            set { _convertsCelsiusToKelvin = value; }
            
        }
            // I can choose to write in two lines or use the auto-implemented property in C# properties...
            // and this enables me to write the 2 lines of code above just in 1 line, just like this:
         */

        public int ConvertsCelsiusTempToKelvin{ get; set; }

        // for the second field now

        // Since I am carrying out multiple(2) things on my KelvinToCelsius class; I need a constructor
        // Or I can say, since I have multiple fields(2) now, I will be needing a constructor to join them together
        // and those 2 things are: converting temperature to kelvin, and converting kelvin to cesius
        // I might also add a list just so I can list out all what my user has converted, if they want it --This might be complex though when I want to write out a UI logic method to handle the Business logic

        // NOTE: I really tried to work with this method in my C#(shapetracker app) but I could not get it, I am hoping that I gey ot this time around
        // and that I am able to successfully write my C# UI method to handle it
        private static List<KelvinToCelsius> _instances = new List<KelvinToCelsius>();

        // NOW ITS TIME FOR MY CONSTRUCTOR
        // After adding my private fields(with an _privateFieldName which is the naming convention for private fields)
        // Its time for a constructor to help me group all of these fields(2) and work with them simultaneously
        // A c# constructor is a method that is called when a new instance of a class is created.
        //  Any information regarding the initial setup of new object can be included in a constructor; and here we have 2 information we want to add 
        // and those are: 1. for my class to be able to take in a kelvin temperature and convert to celsius 
        // and 2. my constructor should be able to take in a celsius temperature and convert it to kelvin

        // a constructor for my KelvinToCelsius temperature that can take in celsius temperature or kelvin temperature

        public KelvinToCelsius(int kelvinTemperature, int celsiusTemperature)
        {
            _convertsCelsiusToKelvin = kelvinTemperature;
            _convertsKelvinToCelsius = kelvinTemperature;

        }





        // public string KelConverterMethod()
        // {
        //     int myDefaultConverter = 273;

        // }

        // public string KelConverterMethod()
        // {
        //     int myDefaultConverter = 273;

        // }

        
    }
}


/*
HOW I DID IT WITH JAVASSCRIPT

function add(degrees, kelvin){
    return degrees + kelvin + "k";
}




// The userInterface Logic
$(document).ready( function(){
    $("#temp").submit( function(event){
        event.preventDefault();
        
        const degrees = parseInt($("#degrees").val());
        const kelvin = +273;
        const output = add(degrees, kelvin);

        $(".output").html(output)

    })
});



*/