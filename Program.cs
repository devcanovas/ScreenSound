Music music = new Music();
music.Name = "Sleepwalking";
music.Author = "Bring Me The Horizon";
music.Duration = 233;
music.Available = true;
Console.WriteLine(music.Description);
music.ShowDetails();

Music music2 = new Music();
music2.Name = "Wait n bleed";
music2.Author = "Slipknot";
music2.Duration = 300;
music2.Available = false;
music2.ShowDetails();

