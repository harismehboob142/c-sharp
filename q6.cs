using System;
class HelloWorld {
  static void Main() {
    const int pine = 100;
    const int oak = 225;
    const int mahogany = 310;
    a:  //label for invalid input by the user
    Console.Write("\nEnter Table Wood (Pine, Oak, Mahogany): ");
    string wood = Console.ReadLine();
    wood = wood.ToLower();   //converting to lowercase for inputs like "oAk" or "OaK" etc
    switch(wood) {
        case "pine":
            Console.Write("\n Pine table price : "+ (pine));
            break;
        case "oak":
            Console.Write("\n Oak table price : "+ (oak));
            break;
         case "mahogany":
            Console.Write("\n Mahogany table price : "+ (mahogany));
            break;
       
        default:
            Console.WriteLine("\n Wrong Chocie");
            goto a;
            break;
}
    
    
  }
}