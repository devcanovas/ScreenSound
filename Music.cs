class Music
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    // Lambda
    public string Description => $"A musica {Name} pertence à banda {Author}";

    public void ShowDetails()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Author}");
        Console.WriteLine($"Duração: {Duration}");
        if (Available)
        {
            Console.WriteLine("Disponível no plano!");
        } else
        {
            Console.WriteLine("Adquira o plano plus*");
        }
    }
}