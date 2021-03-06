using System;
using System.IO;
using LearnSomething.OOP; 

namespace LearnSomething
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tar i hela csv-filen objektorientering i en array
            string[] textFile = File.ReadAllLines(@"/Users/ida/Projects/LearnSomething/LearnSomething/Objektorientering/Objektorientering.csv");

            // För att skapa objekt av varje rad i csv-filen
            foreach (var item in textFile)
            {
                // Skapa en temporär array för att kunna dela upp textsträngen vid ;
                string[] temp = item.Split(";");
                // För att skapa objekt använder vi indexet i vår temporära array.
                new FirstSubjekt(Convert.ToInt32(temp[0]), temp[1], temp[2]);
            }

            // Tar i hela csv-filen systemutveckling i en array
            string[] textfile2 = File.ReadAllLines(@"/Users/ida/Projects/LearnSomething/LearnSomething/Systemutveckling/Systemutveckling.csv");

            foreach (var item in textfile2)
            {
                string[] temp = item.Split(";");

                new SecondSubject(Convert.ToInt32(temp[0]), temp[1], temp[2]);
            }

            string[] textfile3 = File.ReadAllLines(@"/Users/ida/Projects/LearnSomething/LearnSomething/OOP/OOP.csv");

            foreach (var item in textfile3)
            {
                string[] temp = item.Split(";");

                new ThirdSubject(Convert.ToInt32(temp[0]), temp[1], temp[2]);
            }
            

            // Öppnar menyn. 
            Menu.MenuMethod(); 




        }
    }
}
