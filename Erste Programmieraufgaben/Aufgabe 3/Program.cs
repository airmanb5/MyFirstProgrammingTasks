/* 3.	Schreibe ein Programm, welches die Zahlen 1 bis 10 auf dem Bildschirm ausgibt. Verwende dazu einmal eine For Schleife, einmal eine do.…While, und einmal eine while Schleife.

   3.1.	Erkläre den Unterschied der verschiedenen Schleifen, und wann wird welche gebraucht.
                  Erklärung im Programm… */
class Aufgabe3
{
    static void Main()
    {   
        Console.Write("Gib ein, wie oft die Schleife durchgeführt werden soll: ");
        string? input = Console.ReadLine(); 
        int number = Convert.ToInt32(input);
        
        for (int CurrentNumber1 = 1; CurrentNumber1 <= number; CurrentNumber1++)
        {
            Console.WriteLine("For-Schleife: " + CurrentNumber1);
        }
        for (int CurrentNumber1 = 3; CurrentNumber1 < 22; CurrentNumber1 += 2) 
        {
            Console.WriteLine("For-Schleife: " + CurrentNumber1);
        }
        int CurrentNumber2 = 1;

        do
        {
            Console.WriteLine("Do...while-Schleife: " + CurrentNumber2);
            CurrentNumber2++;
        }
        while (CurrentNumber2 < 11);


        int CurrentNumber3 = 1;

        while (CurrentNumber3 < 11)
        {
            Console.WriteLine("While-Schleife: " + CurrentNumber3);
            CurrentNumber3++;
         }
        Console.WriteLine("Die Unterschiede zwischen den verschiedenen Schleifen sind folgendermassen:");
        Console.WriteLine("Bei einer For-Schleife wird das Programm eine vorher bestimmte Anzahl an Malen durchgeführt. Es ist festgelegt, wie oft etwas durchgeführt wird. Sie wird fürs Zählen, Iterieren durch Listen und wenn etwas eine bestimmte Anzahl oft gemacht werden muss, gebraucht.");
        Console.WriteLine("Bei einer Do...While-Schleife wir ein Programm durchgeführt, bevor es prüft, ob die Bedingungen überhaupt erfüllt sind. Somit wird das Programm immer mindesten 1 Mal durchgeführt, obwohl die Bedingungen vielleicht gar nicht erfüllt sind. Sie wird für allles gebraucht, was eine While-Schleife benötigt aber mindestens einmal durchgeführt werden muss.");
        Console.WriteLine("Bei einer While-Schleife prüft vor der Durchführung, ob die Bedingungen erfüllt sind oder nicht. Wenn sie von Anfang an nicht erfüllt sind, läuft die Schleife 0 Mal. Sie wird benötigt, wenn man nicht genau weiss, wie oft etwas durgeführt werden muss");
    }

    
}
