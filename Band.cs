class Band(string Name)
{
    private List<Album> albums = new List<Album>();
    public string Name { get; set; } = Name;
    
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscos()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        albums.ForEach(album =>
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration / 60} minutos)");
        });
    }
}