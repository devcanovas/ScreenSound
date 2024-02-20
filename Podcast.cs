using System.Net;
using System.Reflection.Metadata.Ecma335;

class Podcast(string Host, string Name)
{
    List<Episode> episodes = new List<Episode>();
    public string Host { get; set; } = Host;
    public string Name { get; set; } = Name;
    public string TotalEpisodes => $"Número total de episódios do podcast {Name} é de: {episodes.Count}";
    
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Este é o podcas {Name}, com o host {Host}, com o número total de episódios {TotalEpisodes}");
    }
}