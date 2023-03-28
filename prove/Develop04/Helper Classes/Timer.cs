using System;
using System.Threading;
using System.Collections.Generic;

public class Timer
{

    string[] _animationFrames = new string[] 
    {
            "|o   ",
            "  o  ",
            "   o ",
            "    o|",
            "   o ",
            "  o  ",
            "|o   "
        };


    public void BouncyBall(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {    
            foreach (string frame in _animationFrames)
            {

                Console.Write(frame);

                Thread.Sleep(100);

                Console.Write("\r");

            }
        }
    }

    public void DisplayAnimation(string message, int seconds)
    {
        
        Console.WriteLine($"{message}");
        
        BouncyBall(seconds);

    }


    public bool IsTimeUp(DateTime futureTime)
    {
       
        DateTime currentTime = DateTime.Now;

        if (currentTime > futureTime)
        {
            return true;
        }

        return false;

    }


    public DateTime GetFutureTime(int seconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime futuretime = startTime.AddSeconds(seconds);

        return futuretime;

    }


    public void Count(int seconds)
    {

        Thread.Sleep(seconds * 1000);

    }


    public void DisplayCountdown(string message, int seconds)
    {
        Console.Write($"{message} {seconds}");
        Thread.Sleep(1000);

        for (int i = seconds - 1; i > 0; i--)
        {

            Console.Write($"\b{i}");
            Thread.Sleep(1000);

        }

        Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");

    }
        
}