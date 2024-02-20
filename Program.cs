
Band bringMeTheHorizon = new()
{
    Name = "Bring Me The Horizon"
};

Album albumBringMeTheHorizon = new()
{
    Name = "Sepertinal"
};

Music sleepwalkingMusic = new("Sleepwalking", bringMeTheHorizon)
{
    Duration = 213
};

Music koolaidMusic = new("Kool-Aid", bringMeTheHorizon)
{
    Duration = 354
};

albumBringMeTheHorizon.AddMusic(sleepwalkingMusic);
albumBringMeTheHorizon.AddMusic(koolaidMusic);


bringMeTheHorizon.AddAlbum(albumBringMeTheHorizon);
bringMeTheHorizon.ShowDiscos();