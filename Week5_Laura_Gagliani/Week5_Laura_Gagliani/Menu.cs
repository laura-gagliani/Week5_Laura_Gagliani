using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Laura_Gagliani
{
    class Menu
    {
        internal static void Start()
        {
            bool quit = false;
            do
            {
                Console.WriteLine("\n--------------- MENU GESTIONE CARRIERA ---------------");
                Console.WriteLine("[1] Prenotazione esami");
                Console.WriteLine("[2] Verbalizzazione esami"); 
                
                Console.WriteLine("\n[x] Esci");

                char choice;
                do
                {
                    Console.WriteLine("\nSeleziona dal menu:");
                    choice = Console.ReadKey().KeyChar;
                } while (!(choice == '0' || choice == '1' || choice == '2' || choice == 'x' ));



                switch (choice)
                {
                    case '1':
                        
                        break;
                    case '2':
                        break;
                    
                    case 'x':
                        quit = true;
                        Console.WriteLine("\nChiusura in corso...");
                        break;
                }
            } while (!quit);
        }
    }
}
