using System;

namespace Assingment_9_crime_and_criminal
{
    class Program
    {
        static void Main(string[] args)
        {
            criminal[] criminals = new criminal[3];
            criminals[0]  = new criminal("Joel", 31);
            criminals[1]  = new criminal("Jesus", 51);
            criminals[2]  = new criminal("John", 26);

            DateTime date;
            date = DateTime.Parse("31/01/2021");

            //add crimes to all the three criminals
            //write a for loop below that loops through all3 criminals and ...
            //... loops through each crime for each criminal and print all of the infomation

            {
                int TotalCrime = criminals[i].CountCrimes();

                for (int x = 0; x < TotalCrime; x++)
                {
                    Console.WriteLine("NAME:" + criminals[i].GetName() + "   " + "CRIME:" + criminals[i].GetCrime(x).GetAct() + "   " +
                        "LOCATION:" + criminals[i].GetCrime(x).GetLocation() + "   " + "DATE:" + criminals[i].GetCrime(x).GetDate());
                }

            }
        } 
    }
}
