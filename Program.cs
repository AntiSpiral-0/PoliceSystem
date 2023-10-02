using System;
using System.Collections.Generic;
public class Log
{
    public string Destination { get; set; }
    public Log(string destination)
    {
        Destination = destination;
    }
}

public class TravelLog
{
    public List<Log> Destinations { get; set; }
    public TravelLog()
    {
        Destinations = new List<Log>();
    }
}
class Program
{
    static bool isRunning = true;
    static void Main(string[] args)
    {
        TravelLog travelLog = new TravelLog();
        while (isRunning)
        {
        Console.WriteLine("=========================================================");
        Console.WriteLine("Welcome to the travel log");
        Console.WriteLine("Would you like to see your travel log ? press [s]");
        Console.WriteLine("Would you like to record a visit ? press[r]");
        Console.WriteLine("Would you like to remove a place ? press[re]");
        Console.WriteLine("Would you like to exit ? press[q]");
        string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "R" :
                    string place = Console.ReadLine() ;
                    travelLog.Destinations.Add(new Log(place));
                    break;
                case "RE":
                    Console.WriteLine("Please choose the destination you want to remove") ;
                    string choix = Console.ReadLine();
                    Log ChosenDestination = travelLog.Destinations.FirstOrDefault(Log => Log.Destination == choix);
                    if(ChosenDestination != null)
                    {
                        travelLog.Destinations.Remove(ChosenDestination);
                    }
                    else
                    {
                        Console.WriteLine("Destination not found");
                    }
                    break;
                case "S" :
                    Console.WriteLine("This is your travel log");
                    foreach (Log destination in travelLog.Destinations)
                    {
                        Console.WriteLine(destination.Destination);
                    }
                    break;
                case "Q":
                    Console.WriteLine("Exiting...");
                    isRunning = false;
                    break;
            }
        }
    }
}