using System;
namespace LearnSomething
{
    public class Menu
    {

        public static void MenuMethod()
        {
            StartText.Text();
            Console.WriteLine("\nVad vill du repetera?");
            Console.WriteLine("[1] Grundläggande begrepp Objektorientering");
            Console.WriteLine("[2] Grundläggande begrepp Systemutveckling");
 
            try
            {
                int userChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (userChoice)
                {
                    case 1:
                        FirstSubjekt.PrintOptions();
                        break;
                    case 2:
                        SecondSubject.PrintOptions();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Felaktigt siffra, endast 1 och 2 är valbart tryck på en tanget och försök igen.");
                        Console.ResetColor(); 
                        Console.ReadKey();
                        Console.Clear();
                        MenuMethod();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Felaktig inmatning, tryck på en tanget och försök igen.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                MenuMethod();
            }
            
            
        }

       
    }
}
