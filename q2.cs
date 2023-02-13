
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter choice\n \n1.Calculate Area\n2.Calculate Volume\n3.Calculate Surface Area\n0.Exit the program")
    ;
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice) {
        case 1:
            Console.WriteLine("\nCalculating Area\n");
            break;
        case 2:
            Console.WriteLine("\nCalculating Area\n");
            break;
        case 0:
            Console.WriteLine("\nExiting program\n");
            break;
        default:
            Console.WriteLine("\nERROR! Invalid choice\n");
            break;
}
    
    
  }
}