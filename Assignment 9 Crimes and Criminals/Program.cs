using System;

namespace Assignment_9_Crimes_and_Criminals
{
    class Program
    {
        static void Main(string[] args)
        {

            Criminal[] Criminals = new Criminal[3];
            Criminals[0] = new Criminal("Joel", 31);
            Criminals[1] = new Criminal("Jesus", 51);
            Criminals[2] = new Criminal("John", 26);

            Criminals[0].AddCrime(new Crime(DateTime.Parse("31/01/2020"), "Ascot", "Stealng"));
            Criminals[0].AddCrime(new Crime(DateTime.Parse("30/01/2020"), "Airport", "Stole dog"));

            // HW
            // Add Crimes to all 3 Criminals
            // Write a for loop below which loop through all 3 criminals
            // loops through each crime for each criminal and prints all of the information.
            // Extension, if they have more than 10 crimes then show message EXECUTE 


            //Criminal Joel = new Criminal("Joel", 31);
            //Ciminal Jesus = new Criminal("Jesus", 51);
            //Criminal John = new Criminal("John", 26);

            //Console.WriteLine(Joel.GetName());

            //DateTime Date;
            //Date = DateTime.Parse("31/01/2021");

            //Crime Crime1 = new Crime(Date, "Ascot", "Armed Robbery");
            //Crime Crime2 = new Crime(Date, "Ascot", "Armed Robbery");
            //Crime Crime3 = new Crime(Date, "Ascot", "Armed Robbery");
            //Crime Crime4 = new Crime(Date, "Not Ascot", "UnArmed Robbery");

            //Console.WriteLine(Joel.AddCrime(Crime1));
            //Console.WriteLine(Joel.AddCrime(Crime2));
            //Console.WriteLine(Joel.AddCrime(Crime3));
            //Console.WriteLine(Joel.AddCrime(Crime4));

            //Console.WriteLine(Joel.GetCrime(0).GetAct());
            //Console.WriteLine(Joel.GetCrime(0).GetLocation());


            //for (int i = 0; i < Joel.CountCrime(); i += 1)
            //{
            //    Console.WriteLine(Joel.GetCrime(i).GetAct() + " " +  Joel.GetCrime(i).GetLocation());
            //}
        }
    }
}
