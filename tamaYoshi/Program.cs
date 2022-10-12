using System;
using System.Collections.Generic;


Console.WriteLine("Welcome to your Tamagotchi"); 
Console.WriteLine("What would you like to name it?");
string name = Console.ReadLine();
Console.WriteLine(name +" Is happy to meet you");

Tamagotchi tama = new Tamagotchi();
while(tama.GetAlive()){
tama.PrintStats();

Console.WriteLine("Option 1 : Have a Chat , Option 2 : Feed , Option 3 : Teach a new Word ");
 int num = int.Parse(Console.ReadLine());

switch (num)      // Instead of IF
{
    case 1: tama.Hi() ;break;
    case 2: tama.Feed(); break;    // Break jump out of the case.
    case 3:         
            Console.WriteLine("Enter the new Word: ");
            string word = Console.ReadLine();
            tama.Teach(word); break;
    
    default :  Console.WriteLine("Wrong Option !!!"); break;
}
tama.Tick();
}
Console.ReadLine();
