
partial class Program
{    
    static void Main()
    {
        StackOverflow(); 
    }

    static void StopWatch()
    {
        var stopWatch = new StopWatch();

        while (true)
        {

            Console.Write("Press a button (st = start, sp = stop, q = quit): ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                if (input.ToLower() == "q")
                {
                    break;
                }

                else if (input.ToLower() == "st")
                {
                    stopWatch.Start();
                }

                else if (input.ToLower() == "sp")
                {
                    Console.WriteLine(stopWatch.Stop().ToString(@"hh\:mm\:ss\.fff"));
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    static void StackOverflow()
    {
        Post randomPost = new("Hello", "My Life is amazing");

       
        randomPost.VoteUp();
        randomPost.VoteUp();
        randomPost.VoteUp();
        randomPost.VoteDown();
        randomPost.VoteDown();
        randomPost.VoteUp();
        randomPost.VoteUp();
        randomPost.VoteUp();

        Console.WriteLine(randomPost.VoteValue);
    }
}

