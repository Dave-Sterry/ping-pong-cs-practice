//UI logic
using System;
using System.Collections.Generic;
//using PingPong.Models;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:"); 
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);

        List<string> numberList = new List<string>() {};

        for (int i = 1; i <= number; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                numberList.Add("ping-pong");
            }
            else if (i % 5 == 0)
            {
                numberList.Add("pong");
            }
            else if (i % 3 == 0)
            {
                numberList.Add("ping");
            }
            else
            {    
                numberList.Add(i.ToString());
            }
        }
        foreach (string x in numberList)
        {
            Console.WriteLine(x);
        }
    }
}