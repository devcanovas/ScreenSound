class Music
{
    public string name;
    public string author;
    public int duration;
    public bool available;

    public void ShowDetails()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {author}");
        Console.WriteLine($"Duração: {duration}");
        if (available)
        {
            Console.WriteLine("Disponível no plano!");
        } else
        {
            Console.WriteLine("Adquira o plano plus*");
        }
    }
}