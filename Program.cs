using System;
using System.Collections.Generic;
using System.Text.Json;
class Personal
{
    
    public string Name {get; set ;}
    public int Badgenumber {get ; set ;}
    public Personal(string name , int badgenumber)
    {
        Name = name;
        Badgenumber = badgenumber;
    }
}
class Utryckningar
{
    public string Typ { get; private set; }
    public string Plats { get; private set; }
    public string Tidpunkt { get; private set; }

    public List<Personal> Polices ;
    public Utryckningar(string typ, string plats, string tidpunkt )
    {
        if ((tidpunkt.IndexOf(":") == 2) && (tidpunkt.Length == 5))
        {
            Typ = typ;
            Plats = plats;
            Tidpunkt = tidpunkt;
            Polices = new List<Personal>();
        }
        else
        {
            throw new ArgumentException("Date should be 5 letters and it should contain :");
        }

    }
    public void AddPolice(string name, int number)
    {
        Polices.Add(new Personal(name , number));
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
    static bool IsRunning = true;
    static List<Utryckningar> list1 = new List<Utryckningar>();
    static List<Rapporter> list2 = new List<Rapporter>();
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
                    
                    Console.WriteLine("Please write the type of crime");
                    string type = Console.ReadLine();
                    Console.WriteLine("Please write the place");
                    string place = Console.ReadLine();
                    Console.WriteLine("Please write the time");
                    string time = Console.ReadLine();
                    Console.WriteLine("Please write the name of the officer");
                    string CopName = Console.ReadLine();
                    Console.WriteLine("Please write the bagdge number");
                    int Badgenumber = Convert.ToInt32(Console.ReadLine());
                    Utryckningar emergency = new Utryckningar(type, place, time);
                    emergency.AddPolice(CopName,Badgenumber);
                    list1.Add(emergency);
                    break;

                case "C":
                    Console.WriteLine("Here's the list of emergencies:");
                    foreach (Utryckningar shit in list1)
                    {
                        Console.Write($"Type: {shit.Typ}, Location: {shit.Plats}, Date: {shit.Tidpunkt},");
                        Console.Write("Police Officers:");
                        foreach (Personal police in shit.Polices)
                        {
                            Console.WriteLine($"Name: {police.Name}, Badge Number: {police.Badgenumber}");
                        }
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
                    //Hello
            }
        }
    }
}