using System;

namespace Parking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double total_amount = 0.0;
            
            Charges onehour = new Charges("Liam", 1);
            Console.WriteLine("{0} parked for {1} hour(s). He therefore had to pay {2}€.", onehour.name, onehour.time, onehour.total);
            
            total_amount += onehour.total;
            
            Charges threehour = new Charges("Sophie", 3);
            Console.WriteLine("{0} parked for {1} hour(s). She therefore had to pay {2}€.", threehour.name, threehour.time, threehour.total);
            
            total_amount += threehour.total;
            
            Charges fourhour = new Charges("Adlylin", 4);
            Console.WriteLine("{0} parked for {1} hour(s). She therefore had to pay {2}€.", fourhour.name, fourhour.time, fourhour.total);
            
            total_amount += threehour.total;
            
            Charges sevenhour = new Charges("Robert", 7);
            Console.WriteLine("{0} parked for {1} hour(s). He therefore had to pay {2}€.", sevenhour.name, sevenhour.time, sevenhour.total);
            
            total_amount += threehour.total;
            
            Console.WriteLine("The running total of yesterday's receipt is: {0}€.", total_amount);
        }
    }
}