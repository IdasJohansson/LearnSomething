using System;
using System.Collections.Generic;

namespace LearnSomething
{
    public class Text
    {
        // static lista som går via klassen inte objektet
        private static List<Text> infoList = new List<Text>();

        //fileds
        private int _num;
        private string _title;
        private string _info;

        // konstruktorn som adderar alla objekt som skapas i listan. 
        public Text(int num, string title, string info)
        {
            this._num = num;
            this._title = title;
            this._info = info;
            infoList.Add(this);
        }

        // För att skriva ut samtliga objekt i arrayen om man vill se alla frågor och svar
        public static void Print()
        {
            foreach (var item in infoList)
            {
                Console.WriteLine("Nr: {0}. {1}", item._num, item._title);
                Console.WriteLine("{0}", item._info);
            }
        }

        // RandomTitle and PrintCorrectInfo ändras inte.. för att koden inte körs igen i static.
        // Behöver det ligga i samma metod?
        // Pusha upp till git, gör en ny bransch och prova? 
        // Gör random i en metod och gör två olika if satser med metoder som skriver ut olika saker....?
        // Gör en counter som räknar poäng vid varje rätt svar. 

        // Random generator för PrintRandomTitel och CorrectInfo
        static Random rnd = new Random();
        static int count = rnd.Next(1, 23); // Antal rader i cvs filen

        // Använder static Random rnd och count
        public static void PrintRandomTitle()
        {
            foreach (var item in infoList)
            {
                // Skriver ut titeln 
                if (count == item._num)
                {
                    Console.WriteLine(item._title);

                }
            }
        }

        // Använder static Random rnd och count
        public static void PrintCorrectInfo()
        {
            foreach (var item in infoList)
            {
                // Skriver ut infon om titeln 
                if (count == item._num)
                {
                    Console.WriteLine($"{item._info}");
                }
            }
        }


        public static void PrintRandomInfo()
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 23);

            foreach (var item in infoList)
            {
                if (count == item._num)
                {
                    Console.WriteLine($"{item._info}");
                }
            }
        }

        public static void PrintRandomInfo2()
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 23);

            foreach (var item in infoList)
            {
                if (count == item._num)
                {
                    Console.WriteLine($"{item._info}");
                }
            }
        }

        // Skriver ut titeln och alla alternativen, använder ej, bara för test. 
        public static void PrintAllOptions()
        {
            PrintRandomTitle();
            PrintCorrectInfo();
            PrintRandomInfo();
            PrintRandomInfo2();
        }


        static Random secondRnd = new Random();
        static int unKnown = secondRnd.Next(1, 4); // Int unKnow styr vilket case som skrivs ut

        public static void PrintOptions()
        {
            
            Console.Write("\nVad menas med: ");
            PrintRandomTitle();

            // Tre switch-satser med Correct info på olika platser innebär att correct info hamnar på olika ställen varje gång.
            Console.WriteLine("\nAlternativ 1:");
            switch (unKnown)
            {
                case 1:
                    PrintCorrectInfo();
                    break;
                case 2:
                    PrintRandomInfo();
                    break;
                case 3:
                    PrintRandomInfo2();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nAlternativ 2:");
            switch (unKnown)
            {
                case 1:
                    PrintRandomInfo2();
                    break;
                case 2:
                    PrintCorrectInfo();
                    break;
                case 3:
                    PrintRandomInfo();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nAlternativ 3:");
            switch (unKnown)
            {
                case 1:
                    PrintRandomInfo();
                    break;
                case 2:
                    PrintRandomInfo2();
                    break;
                case 3:
                    PrintCorrectInfo();
                    break;
                default:
                    break;
            }

            //UserGuess(); 

        }

        // Användarens gissning
        public static void UserGuess()
        {
            Console.WriteLine("\nVilket är det rätta alternativet?");

            int userGuess = Convert.ToInt32(Console.ReadLine());
            bool run = true; 

            while (run)
            {
                if (userGuess == unKnown)
                {
                    Console.WriteLine("Rätt svar!");
                    Console.WriteLine("Tryck på en tanget för nästa fråga...");
                    run = false;
                    Console.ReadKey();
                    Console.Clear(); 
                    PrintOptions(); 
                }
                else
                {
                    Console.WriteLine("Tyvärr det var fel :( Gissa igen: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
            }
            
        }

    }

}
