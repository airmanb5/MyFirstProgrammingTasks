/* 11. In unserem Kalender sind zum Ausgleich der astronomischen und kalendarischen Jahreslänge in regelmäßigen Abständen Schaltjahre eingebaut. Zur exakten Festlegung der Schaltjahre dienen die folgenden Regeln:
•	Ist die Jahreszahl durch 4 teilbar, so ist das Jahr ein Schaltjahr. Diese Regel hat allerdings eine Ausnahme:
o Ist die Jahreszahl durch 100 teilbar, so ist das Jahr kein Schaltjahr. Diese Ausnahme hat wiederum eine Ausnahme:
	 Ist die Jahreszahl durch 400 teilbar, so ist das Jahr doch ein Schaltjahr.
Erstellen Sie ein Programm, das berechnet, ob eine vom Benutzer eingegebene Jahreszahl ein Schaltjahr bezeichnet oder nicht. */

using System.ComponentModel.Design;

class Aufgabe11
{
    static void Main()
    {
        bool isLeapYear = false;
        Console.Write("Welche Jahreszahl möchstest du auf ein Schaltjahr überprüfen? ");
        int jahreszahl = Convert.ToInt32(Console.ReadLine());
        if (jahreszahl % 400 == 0)
        {
            isLeapYear = true;
        }
        else
        {
            if (jahreszahl % 100 == 0)
            {
                isLeapYear = false;
            }
            else
            {
                if (jahreszahl % 4 == 0)
                {
                    isLeapYear = true;
                }
            }
        }
        if (isLeapYear)
        {
            Console.WriteLine("Das Jahr " + jahreszahl + " ist ein Schaltjahr.");
        }
        else
        {
            Console.WriteLine("Das Jahr " + jahreszahl + " ist kein Schaltjahr.");
        }
    }
}
