using TestSummarisingText;

namespace TestSummarisingText
{
    class TestSummarisingText
    {
        static void Main()
        {
            var sentence = "This is going to be a really really really really really really really really really long text.";

            string summary = StringUtility.SummerizeText(sentence, 25);

            Console.WriteLine("Summarized Text: " + summary);
        }
    }
}