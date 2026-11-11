// 12.2.Verwende ein List. Der Anwender kann solange Schulnoten eingeben, bis er eine 0 eingibt. Es dürfen auch nur gültige Schulnoten eingegeben werden

using System.Diagnostics.CodeAnalysis;

class Aufgabe12_2
{
    static void Main()
    {
        double inputGrade = -1;
        double sum = 0;
        List<double> grades = new List<double>();
        while (inputGrade != 0)
        {
            Console.WriteLine($"Zahl Nr.{grades.Count + 1} eingeben: ");
            inputGrade = Convert.ToDouble(Console.ReadLine());
            if (inputGrade >= 1 && inputGrade <= 6)
            {
                    grades.Add(inputGrade);
            }
            else
            {
                if (inputGrade != 0) 
                {
                    Console.WriteLine("Dies ist keine Schulnote. Versuch es nochmal");
                }                 
            }
        }
        foreach (double grade in grades)
        {
            sum += grade;
        }
        double meanValue = sum / grades.Count;
        Console.WriteLine($"Der Durchscnitt dieser {grades.Count} Zahlen lautet: {meanValue}.");
    }
}