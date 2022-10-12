using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new List<string>() { "Hewwo" };
    private bool isAlive;
    private Random generator;
    public string name;

    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }

    public void Feed()
    {
        Console.WriteLine($" [{name}] eats and becomes less hungry");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
            Console.WriteLine($" [{name}] is full");
        }
    }

    public void Hi()
    {
        int wordNum = generator.Next(words.Count); // generates random number
        Console.WriteLine($" [{name}] says: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{name}] learns: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {   
            Console.WriteLine("Game Over");
            isAlive = false;
           
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public bool GetAlive()  // ITS RETURNING THE VALUE OF ATTRIBUTE ISALIVE
    {
        return isAlive;
    }
    public void ReduceBoredom() // reduces boredom
  {
    Console.WriteLine($" [{name}] is now less bored!");

    boredom -= 2;
    if (boredom < 0)
    {
      boredom = 0;
    }
  }

}
