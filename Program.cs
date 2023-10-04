using System;
using System.Collections.Generic;

class Utryckningar
{
    public string Typ { get; private set; }
    public string Plats { get; private set; }
    public string Tidpunkt { get; private set; }
    public string Poliser { get; private set; }
    public Utryckningar(string typ, string plats, string tidpunkt, string poliser)
    {
        if ((tidpunkt.IndexOf(":") == 2) && (tidpunkt.Length == 5))
        {
            Typ = typ;
            Plats = plats;
            Tidpunkt = tidpunkt;
            Poliser = poliser;
        }
        else
        {
            throw new ArgumentException = ("Date should be 5 letters and it should contain :");
        }

    }

}
class Rapporter
{
    public int Rapportnummer { get; private set; }
    public string Dat { get; private set; }

    public string Policestation { get; private set; }
    public string Description { get; private set; }

    public Rapporter(int rapportnummer, string dat, string policestation, string description)
    {
        if ((dat.IndexOf("/") == 2) && (dat.IndexOf("/") == 5) && (dat.Length == 8))
        {
            Rapportnummer = rapportnummer;
            Dat = dat;
            Policestation = policestation;
            Description = description;
        }
        else
        {
            throw new ArgumentException("You have to include two / in a date");
        }
    }
}

class Program
{
    bool IsRunning = true;
    List<Utryckningar> list1 = new List<Utryckningar>;
    List<Rapporter> list2 = new List<Rapporter>;
    static void Main(string[] args)
    {
        while (IsRunning)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("R - Register an emergency");
            Console.WriteLine("RR - Register a report");
            Console.WriteLine("C - Check emergencies");
            Console.WriteLine("CR - Check reports");
            Console.WriteLine("X - Exit");

            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "R":
                    // Handle registering an emergency
                    break;
                case "RR":
                    // Handle registering a report
                    break;
                case "C":
                    Console.WriteLine("Here's the list of emergencies:");
                    foreach (Utryckningar emergency in list1)
                    {
                        Console.WriteLine($"Type: {emergency.Typ}, Location: {emergency.Plats}, Date: {emergency.Tidpunkt}, Police: {emergency.Poliser}");
                    }
                    break;
                case "CR":
                    Console.WriteLine("Here's the list of reports:");
                    foreach (Rapporter report in list2)
                    {
                        Console.WriteLine($"Report Number: {report.Rapportnummer}, Date: {report.Dat}, Police Station: {report.Policestation}, Description: {report.Description}");
                    }
                    break;
                case "X":
                    IsRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}