using System;
using System.Collections.Generic;

namespace LearnSomething
{
    public class SecondSubject
    {
        private static List<SecondSubject> infoList = new List<SecondSubject>();

        private static int wrongGuess = 0;

        //Fields
        private int _num;
        private string _title;
        private string _info;

        public SecondSubject(int num, string title, string info)
        {
            this._num = num;
            this._title = title;
            this._info = info;
            infoList.Add(this);
        }

        public static void PrintRandomTitle(int count)
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

        // Detta är metoden för rätt svar på ämnet/frågan, count skickas med i PrintOptionsMetoden för att siffran ska vara samma som i PrintRandomTitle
        public static void PrintCorrectInfo(int count)
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
            int count = rnd.Next(1, infoList.Count + 1); // infoList.Count tar in längden på listan + 1 för att man ska få med även det sista objektet i listan. 

            foreach (var item in infoList)
            {
                if (count == item._num)
                {
                    Console.WriteLine($"{item._info}");
                }
            }
        }

        // Slumpar ett svar
        public static void PrintRandomInfo2()
        {
            Random rnd = new Random();
            int count = rnd.Next(1, infoList.Count + 1); ;

            foreach (var item in infoList)
            {
                if (count == item._num)
                {
                    Console.WriteLine($"{item._info}");
                }
            }
        }


        public static void PrintOptions()
        {
            // Rubrik som står överst hela tiden. 
            StartText.Text();

            // Styr PrintRandomTitle och PrintCorrectInfo
            Random rnd = new Random();
            int nr = rnd.Next(1, infoList.Count + 1);

            // Styr vilket case som ska visas i switch-satsen samt skickar vidare samma siffra till UserGuess
            Random secondRnd = new Random();
            int unKnown = secondRnd.Next(1, 4);


            Console.Write("\nVad menas med: ");
            PrintRandomTitle(nr);

            // Tre switch-satser med Correct info på olika platser innebär att correct info hamnar på olika ställen varje gång.
            Console.WriteLine("\nAlternativ 1:");
            switch (unKnown)
            {
                case 1:
                    PrintCorrectInfo(nr);
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
                    PrintCorrectInfo(nr);
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
                    PrintCorrectInfo(nr);
                    break;
                default:
                    break;
            }

            // Gör så att man kommer vidare till UserGuess tillsammans med vilken siffra som är rätt alternativ i switchsatserna. 
            UserGuess(unKnown);

        }


        // Användarens gissning, int unKnown skickas med från PrintOptions och kallas här för correctAnswer
        public static void UserGuess(int correctAnswer)
        {
            Console.WriteLine("\nVilket är det rätta alternativet?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(Välj 4 för att avsluta repetitionen och se antal felaktiga svar.)");
            Console.WriteLine("(Välj 5 för att byta ämne.)");
            Console.ResetColor();

            bool run = true;

            while (run)
            {
                try
                {
                    int userGuess = Convert.ToInt32(Console.ReadLine());

                    if (userGuess == correctAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Rätt svar!");
                        Console.WriteLine("Tryck på en tanget för nästa fråga...");
                        Console.ResetColor(); 
                        run = false;
                        Console.ReadKey();
                        Console.Clear();
                        PrintOptions();
                    }
                    else if (userGuess == 4)
                    {
                        Console.WriteLine("Antal felaktiga svar: {0}", wrongGuess);
                        Console.WriteLine("Tryck på valfri tanget för att avsluta programmet.");
                        run = false;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (userGuess == 5)
                    {
                        Console.Clear();
                        Menu.MenuMethod();
                    }
                    else
                    {
                        wrongGuess++;
                        Console.ForegroundColor = ConsoleColor.DarkRed; 
                        Console.WriteLine("Tyvärr det var fel :( Gissa igen: ");
                        Console.ResetColor();
                        userGuess = Convert.ToInt32(Console.ReadLine());
                    }

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du kan bara använda siffror!");
                    Console.WriteLine("Försök igen: ");
                    Console.ResetColor();
                }

            }

        }
    }
}
