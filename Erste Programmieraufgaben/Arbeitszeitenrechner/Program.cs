class Arbeitszeitenrechner
{
    static void Main()
    {
        TimeSpan requiredWorkTime = new TimeSpan(8, 12, 0);
        TimeSpan minLunchTime = new TimeSpan(0, 30, 0);

        Console.Write("Startzeit eingeben: (HH:mm): ");
        DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(Console.ReadLine()));

        Console.Write("Startzeit der Mittagspause eingeben: (HH:mm): ");
        DateTime lunchStart = DateTime.Today.Add(TimeSpan.Parse(Console.ReadLine()));

        Console.Write("Ende der Mittagspause: (HH:mm): ");
        DateTime lunchEnd = DateTime.Today.Add(TimeSpan.Parse(Console.ReadLine()));

        TimeSpan lunchTime = lunchEnd - lunchStart;

        if (lunchTime < minLunchTime)
            lunchTime = minLunchTime;

        requiredWorkTime += lunchTime;

        TimeSpan workedBeforeLunch = lunchStart - startTime;
        requiredWorkTime -= workedBeforeLunch;
        TimeSpan remainingWork = requiredWorkTime;
        DateTime finishTime = lunchStart + remainingWork;

        Console.WriteLine($"Arbeit vor der Mittagspause:    {workedBeforeLunch:hh\\:mm}");
        Console.WriteLine($"Verbleibende Arbeitszeit:       {remainingWork:hh\\:mm}");
        Console.WriteLine($"Du musst arbeiten bis:          {finishTime:HH:mm}");
    }

}




