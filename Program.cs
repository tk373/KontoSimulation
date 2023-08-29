using System;


namespace KontoSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe1;
            int auswahl1bis4 = 0;

           
            while (auswahl1bis4 != 4)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Bitte wählen Sie die gewünschte Funktion aus:");
                Console.WriteLine("1) Neue Transaktion erfassen");
                Console.WriteLine("2) Existierende Transaktion mutieren");
                Console.WriteLine("3) Alle Transationen auflisten");
                Console.WriteLine("4) Beenden ");

                eingabe1 = Console.ReadLine();
                auswahl1bis4 = Convert.ToInt32(eingabe1);
                switch (auswahl1bis4)
                {
                    case 1:
                        {
                            string eingabeTransaktion;
                            double eingabeGerundet;
                            double eingabeCHF;
                            Console.WriteLine("Bitte geben Sie einen positiven Betrag [CHF] ein");
                            eingabeTransaktion = Console.ReadLine();
                            eingabeCHF = Convert.ToDouble(eingabeTransaktion);

                            if (eingabeCHF > 0)
                            {
                                eingabeGerundet = eingabeCHF * 20;
                                eingabeGerundet = Math.Round(eingabeGerundet);
                                eingabeGerundet = eingabeGerundet / 20;
                                Console.WriteLine($"Der Betrag {eingabeGerundet} CHF wurde übermittelt");
                                Console.WriteLine("Um zum Hauptmenü zu kommen drücken Sie ENTER");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Eingabe Ungültig!");
                                Console.WriteLine("Um zum Hauptmenü zu kommen drücken Sie ENTER");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Keine existierenden Transaktionen Vorhanden");
                            Console.WriteLine("Um zum Hauptmenü zu kommen drücken Sie ENTER");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Keine existierenden Transaktionen Vorhanden");
                            Console.WriteLine("Um zum Hauptmenü zu kommen drücken Sie ENTER");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Programm beendet");
                            Console.WriteLine("Zum beenden ENTER drücken");
                            Console.ReadLine();
                            break;
                        }
                }

            }

        }
    }
}
