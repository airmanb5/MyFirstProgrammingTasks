class Aufgabe24
{
    static void Main()
    {
        Book tributeVonPanem = new Book("13 978‑0‑439‑02348‑1", "Tribute von Panem", "Suzanne Collins");
        Book anderes = new Book("13 978‑0‑439‑02348‑1", "Tribute von Panem", "Suzanne Collins");

        Console.WriteLine(tributeVonPanem.ISBN);

        Console.WriteLine(Book.IsbnVergleich(tributeVonPanem.ISBN, ));
    }
}

public class Book
{
    public Book(string isbn, string titel, string autor)
    {
        this.ISBN = isbn;
        this.Titel = titel;
        this.Autor = autor;
    }
    
    public string ISBN { get; set; }
    public string Titel { get; set; }
    public string Autor { get; set; }

    static public string IsbnVergleich(string isbn1, string isbn2)
    {
        return ($"Du hast die Titel {isbn1} und {isbn2} verglichen.");

    }

    static public void AutorVergleich(string autor1, string autor2)
    {
        Console.WriteLine($"Du hast die Titel {autor1} und {autor2} verglichen.");

    }

    static public void TitelVergleich(string titel1, string titel2)
    {
        Console.WriteLine($"Du hast die Titel {titel1} und {titel2} verglichen.");
    }
}
