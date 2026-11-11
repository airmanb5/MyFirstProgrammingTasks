// 10. Schreiben Sie ein Programm, das zu einem gegebenen Anfangskapital bei einem vorgegebenen jährlichen Zinssatz berechnet, wie viele Jahre benötigt werden, damit das Kapital eine bestimmte Zielsumme überschreitet.
// 10.1 Am Ende des Programms wird der Anwender gefragt, ob er das Programm beenden möchte oder ob er nochmal von vorne anfangen möchte. Durch Eingabe der Buchstaben q oder Q wird das Programm beendet. Bei allen anderen Buchstaben wird das Programm von vorne gestartet
class Aufgabe10
{
    static void Main()
    {
        string? restart;
        do
        {
            double zinssatz = 5;
            double zielsumme = 10000;
            int jahre = 0;
            Console.Write("Gib das Startkapital an: ");
            double startKapital = Convert.ToDouble(Console.ReadLine());
            double aktuellesKapital = startKapital;

            while (aktuellesKapital < zielsumme)
            {
                aktuellesKapital += aktuellesKapital * zinssatz / 100;
                jahre++;
            }
            Console.WriteLine("Benötigte Laufzeit: " + jahre + " Jahre");
            Console.Write("Drücke Q um das Programm zu beenden: ");
            restart = Console.ReadLine();
        } while (restart?.ToLower() != "q");
    }
}
