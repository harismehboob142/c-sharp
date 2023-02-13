
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter a letter: ");
    char letter = char.Parse(Console.ReadLine());

    int number = (int)letter;
    Console.WriteLine("Letter: " + letter);
    Console.WriteLine("Number equivalent: " + number); 

  }
}