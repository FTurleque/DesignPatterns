// See https://aka.ms/new-console-template for more information
using DesignPatterns.Class.State.MediaVideo;

Console.WriteLine("Hello, World!");

Video video = new Video();
Console.WriteLine("new vid -> " + video);

video.PlayTheVideo();
Console.WriteLine(video);

video.PauseTheVideo();
Console.WriteLine(video);

video.PlayTheVideo();
Console.WriteLine(video);

video.StopTheVideo();
Console.WriteLine(video);

video.StopTheVideo();
Console.WriteLine(video);

video.PauseTheVideo();
Console.WriteLine(video);

video.PlayTheVideo();
Console.WriteLine(video);

video.PlayTheVideo();
Console.WriteLine(video);

video.PauseTheVideo();
Console.WriteLine(video);
