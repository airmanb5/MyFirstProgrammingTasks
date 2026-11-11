//19. +Erzeuge ein Programm, was alle eingegebenen Integer Zahlen in ein Array schreibt. Die Zahlenfolge wird mit einer Null abgeschlossen; Nutze Array.Sort um die Zahlen zu sortieren und gebe alle Elemente des Arrays mit der Methode Array.ForEach aus 
class Aufgabe19
{
    static void Main()
    {
        int amountArray = 1000;
        int i = 0;
        int[] numbers = new int[amountArray];

        for (i = 0; i < amountArray; i++)
        {

            Console.WriteLine($"Zahl {i + 1} eingeben: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] == 0)
            {
                break;
            }
        }
        Array.Sort(numbers);

        Array.ForEach(numbers, x =>
        {
            if (x != 0)
            {
                Console.WriteLine(x);
            }
        });
        Console.WriteLine("");
        Console.WriteLine("Erklärung eines Arrays: Ein Array ist eine Datenstruktur, mit der man mehrere Werte in einer Variable speichern kann. Die anzahl der möglichen Speicherungen wird im Vorfeld festgelegt und kann nicht mehr verändert werden.");


    }
}

