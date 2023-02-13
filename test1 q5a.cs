
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter your home planet name : ");
    string planet = Console.ReadLine();
    if (planet.ToLower() == "earth"){
        Console.WriteLine(planet + "! You are an Earthling and you have 10 fingers.");
        
    }
    else if (planet.ToLower() == "mars"){
        Console.WriteLine(planet + "! You are a Martian and you have 8 fingers.");
    }
    else if (planet.ToLower() == "venus"){
        Console.WriteLine(planet + "! You are a Venusian and you have 12 fingers.");
    }
    else{
        Console.WriteLine("I am sorry I don't know of that planet.");
    }
  }
}