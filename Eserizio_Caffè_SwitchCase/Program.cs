using System;

namespace Eserizio_Caffè_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string rln, scelta;
            double costo=0;
            int contatore=0;
            
            Console.WriteLine("Vuole acquistare un caffè?(Inserire si o no)");
            scelta = Convert.ToString(Console.ReadLine());
            do
            {               
                Console.WriteLine("Caffè: 1=ristretto, 2=normale, 3=lungo");
                Console.WriteLine("Seleziona il prodotto:");
                rln = Console.ReadLine();
                
                if (scelta == "si")
                {
                    switch (rln)
                    {
                        case "1":
                        case "ristretto":
                            costo += 0.25;
                            contatore++;
                            break;

                        case "2":
                        case "normale":
                            costo = costo + 0.25;
                            goto case "1";

                        case "3":
                        case "lungo":
                            costo = costo + 0.50;
                            goto case "1";
                        default:
                            Console.WriteLine("Selezione non valida");
                            break;
                    }
                }              
                else 
                {
                    break;
                }
                Console.WriteLine("Vuole acquistare un altro prodotto?");
                scelta = Console.ReadLine();
            } while (scelta == "si");
            if (costo != 0)
            {
                Console.WriteLine($"Inserire {costo} euro per ottenere il prodotto, hai effettuato {contatore} acquisto/i.");
            }

        }
    }
}
