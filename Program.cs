using System;
using System.Collections.Generic;

class Utryckningar()
{
    private string Typ { get; set; }
    private string Plats { get; set; }
    private string Tidpunkt { get; set; }
    private string Poliser { get; set; }
    public Utryckningar(string typ, string plats, string tidpunkt, string poliser)
    {
        if ((tidpunkt.IndexOf(":") == 2) && (tidpunkt.Length() == 5))
        {
            Typ = typ;
            Plats = plats;
            Tidpunkt = tidpunkt;
            Poliser = poliser;
        }
        else
        {
            throw new ArgumentException = 
      
        }

    }

}
class Program
{
    bool IsRunning = true;
    List<Utryckningar> list = new List<Utryckningar>;
    static void Main(string[] args)
    {
        Console.WriteLine("=============================");
        Console.WriteLine("");
    }
}