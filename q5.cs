using System;
class HelloWorld {
  static void Main() {
    a:  //label for invalid input by the user
    Console.Write("\nEnter Day of the week (Sun, Mon, Tue, Wed, Thu): ");
    string day = Console.ReadLine();
    switch(day) {
        case "Sun":
            Console.Write("\n Home");
            break;
        case "Mon":
            Console.Write("\n Work");
            break;
         case "Tue":
            Console.Write("\n Work");
            break;
        case "Wed":
            Console.Write("\n Home");
            break;
         case "Thu":
            Console.Write("\n Work");
            break;
        case "Fri":
            Console.Write("\n Work");
            break;
         case "Sat":
            Console.Write("\n Work");
            break;
       
        
        default:
            Console.WriteLine("\n Wrong Chocie");
            goto a;
            break;
}
    
    
  }
}