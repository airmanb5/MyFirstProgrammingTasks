class TestDateTimeAndTimeSpan
{
    static void Main()
    {
        TestDateTime();
    }

    static void TestDateTime()
    {
        var daytime = new DateTime(2015, 1, 1);
        var now = DateTime.Now;
        var today = DateTime.Today;

        //Console.WriteLine("Hour: " + now.Hour);
        //Console.WriteLine("Minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        var yesterdy = now.AddDays(-1);

        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString("yyyy-MM-dd-HH:MM"));
    }

    static void TestTimeSpan()
    {
        //Creating
        var timeSpan = new TimeSpan(1,2,3);

        var timeSpan1 = new TimeSpan(1,0,0);
        var timeSpan2 = TimeSpan.FromHours(1);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;

        Console.WriteLine("Duration: " + duration);

        //Properties
        Console.WriteLine("Minutes: " + timeSpan.Minutes);
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

        //Add & Subtract
        Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

        //ToString
        Console.WriteLine("ToString: " + timeSpan.ToString());

        //Parse
        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
    }

    static void TestStringTrim()
    {
        string originalText = " a b c d e f ";
        string trimmedText = originalText.Trim();
        Console.WriteLine("Untrimmed:" + originalText + "heehee");
        Console.WriteLine("Trimmed:" + trimmedText + "heehee");
    }
}
