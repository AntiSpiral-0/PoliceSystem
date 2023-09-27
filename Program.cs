using System;

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
    bool isRunning = true;
    public void Main(string[] args)
    {
        TravelLog travelLog = new TravelLog();
        Console.WriteLine("=========================================================");
        Console.WriteLine("Welcome to the travel log");
        Console.WriteLine("Would you like to record a visit ? press[r]");
        Console.WriteLine("Would you like to remove a place ? press[re]");
        Console.WriteLine("Would you like to exit ? press[q]");
        string choice = Console.ReadLine();
        while (isRunning)
        {
            switch (choice.ToUpper())
            {
                case "R" :
                    string place = Console.ReadLine() ;
                    travelLog.Destinations(new Log(place));
            }

        }

    }
}