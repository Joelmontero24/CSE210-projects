List<Video> videos = new();

Video video1 = new("Unboxing the New Ipad 11", "Maya Rosa", 480);
video1.AddComment(new Comment("Carlos Ruiz", "Color accuracy outS of the box looks great."));
video1.AddComment(new Comment("Elena Paniagua", "How is the stand adjustment on this model?"));
video1.AddComment(new Comment("Trevor Brooks", "Super helpful overview before I buy."));
videos.Add(video1);

Video video2 = new("Reach C1 english level", "Joel Montero", 310);
video2.AddComment(new Comment("Sofía Montero", "This video is amazing."));
video2.AddComment(new Comment("Jose Alcantara", "You got a new subcriber"));
video2.AddComment(new Comment("Prima Sosua", "Spot on!"));
videos.Add(video2);

Video video3 = new("Testing Camera Cannon", "Hanoi Martinez", 725);
video3.AddComment(new Comment("Daniela Ortiz", "Low-light performance is surprisingly solid."));
video3.AddComment(new Comment("Samir Rosado", "Compact enough to carry all day on trips."));
video3.AddComment(new Comment("Grace Sanchez", "Loved the sample clips from the city walk."));
videos.Add(video3);

foreach (Video video in videos)
{
    video.Display();
}