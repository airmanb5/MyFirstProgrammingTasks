// 6.Nachdem eine untere und eine obere Grenze(ganze Zahlen) eingegeben wurde, sollen alle geraden Zahlen ausgegeben werden
// 6.1 Es soll geprüft werden, ob die Obergrenze grösser ist als die Untergrenze.
class Aufgabe6
{
    static void Main()
    {
        int inputuntergrenze;
        int inputobergrenze;
        do
        {
            Console.Write("Gib die Untergrenze ein: ");
            inputuntergrenze = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gib die Obergrenze ein: ");
            inputobergrenze = Convert.ToInt32(Console.ReadLine());

            if (inputuntergrenze >= inputobergrenze)
            {
                Console.WriteLine("Die Obergrenze muss grösser sein als die Untergrenze. Bitte wähle eine neue Ober- und Untergrenze.");

            }
        } while (inputuntergrenze >= inputobergrenze);

        Console.WriteLine("Die geraden Zahlen in diesem Bereich lauten: ");
        for (int startnumber = inputuntergrenze; startnumber <= inputobergrenze; startnumber++)
        {
            if (startnumber % 2 == 0)
            {
                Console.WriteLine(startnumber);
            }
        }
    }
}

