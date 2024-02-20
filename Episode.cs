class Episode(string Title, string Description, int Duration)
{
    public int Duration { get; set; } = Duration;
    public string Title { get; set; } = Title;
    public string Description { get; set; } = Description;
    
    public List<string> guests = new List<string>();
    
    public void AddGuest(string Name)
    {
        guests.Add(Name);
    }

    public void GetGuests()
    {
        guests.ForEach(guest => Console.WriteLine(guest));
    }

}