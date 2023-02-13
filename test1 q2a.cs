
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter you name : ");
    string name = Console.ReadLine();
    Console.Write("Enter monthly visa bill : ");
    int bill = Convert.ToInt32(Console.ReadLine());
    int annual_bill = bill*12;

    Console.WriteLine("Name : " + name);
    Console.WriteLine("Annual Bill : " + annual_bill); 

  }
}