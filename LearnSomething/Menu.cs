using System;
namespace LearnSomething
{
    public class Menu
    {

        public static void MenuMethod()
        {
            StartText.Text();
            Console.WriteLine("\nVad vill du repetera?");
            Console.WriteLine("Skriv [A] för Grundläggande begrepp Objektorientering");
            Console.WriteLine("Skriv [B] för Grundläggande begrepp Systemutveckling");
 
            try
            {
                char userChoice = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                switch (Char.ToUpper(userChoice))
                {
                    case 'A':
                        FirstSubjekt.PrintOptions();
                        break;
                    case 'B':
                        SecondSubject.PrintOptions();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Felaktigt tecken, endast bokstaven A och B är valbart, tryck på en tanget och försök igen.");
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
