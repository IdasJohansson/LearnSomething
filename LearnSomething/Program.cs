using System;
using System.IO; 

namespace LearnSomething
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tar i hela csv-filen i en array
            string[] textFile = File.ReadAllLines(@"/Users/ida/Projects/LearnSomething/LearnSomething/Bok8.csv");

            // För att skapa objekt av varje rad i csv-filen
            foreach (var item in textFile)
            {
                // Skapa en temporär array för att kunna dela upp textsträngen vid ;
                string[] temp = item.Split(";");
                // För att skapa objekt använder vi indexet i vår temporära array.
                new Text(Convert.ToInt32(temp[0]), temp[1], temp[2]); 
            }

           
            // Startar programmet
            Text.PrintOptions();
            
            
            


        }
    }
}
