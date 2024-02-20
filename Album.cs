class Album
{
    private List<Music> musics = new List<Music>();
    public string Name { get; set; }
    public int TotalDuration => musics.Sum(music => music.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowMusics()
    {
        Console.WriteLine($"Lista de músicas do album {Name}:\n");
        musics.ForEach(music =>
        {
            Console.WriteLine($"Música: {music.Name}");
        });
    }
}