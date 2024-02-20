Band bringMeTheHorizon = new("Bring Me The Horizon");

Album albumBringMeTheHorizon = new("Sepertinal");

Music sleepwalkingMusic = new("Sleepwalking", bringMeTheHorizon)
{
    Duration = 213,
    Available = true,
};

Music koolaidMusic = new("Kool-Aid", bringMeTheHorizon)
{
    Duration = 354,
    Available = false,
};

albumBringMeTheHorizon.AddMusic(sleepwalkingMusic);
albumBringMeTheHorizon.AddMusic(koolaidMusic);
bringMeTheHorizon.AddAlbum(albumBringMeTheHorizon);

sleepwalkingMusic.ShowDetails();
koolaidMusic.ShowDetails();
albumBringMeTheHorizon.ShowMusics();
bringMeTheHorizon.ShowDiscos();

// PODCAST CHALLENGE
