// 7. Schreibe ein Programm, das die ungeraden Zahlen bis 100 addiert und das Ergebnis ausgibt.
class Aufgabe7
{
    static void Main()
    {
        int startnumber = 1;
        int endnumber = 100;
        int addednumbers = 0;

        for (int currentnumber = startnumber; currentnumber <= endnumber; currentnumber++)
        {
            if (currentnumber % 2 == 1)
            {
                addednumbers += currentnumber;

            }
        }
        Console.WriteLine("Alle ungeraden Zahlen von 1 bis 100 zusammen addiert ergeben " + addednumbers + ".");
    }
}
