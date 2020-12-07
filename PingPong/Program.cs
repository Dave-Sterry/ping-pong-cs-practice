//UI logic
using System;
using System.Collections.Generic;
using PingPong.Models;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Pleasea enter a number:"); 
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);

        List<int> numberList = new List<int> {};

        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0)
            {
                numberList.Add("ping");
            }
            else if (i % 5 == 0)
            {
                numberList.Add("pong");
            }
            else if (i % 5 && i % 3)
            {
                numberList.Add("ping-pong")
            }
            else
            {
                numberList.Add(i);
            }
        }
 

    }
}