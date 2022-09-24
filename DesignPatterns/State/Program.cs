// See https://aka.ms/new-console-template for more information
using DesignPatterns.Class.State.MediaVideo;
using DesignPatterns.Class.State.StateButton;

Console.WriteLine("Hello, World!");

Video video = new Video();
Console.WriteLine("new vid -> " + video.ToString());

video.PlayTheVideo();
Console.WriteLine(video.ToString());

video.PauseTheVideo();
Console.WriteLine(video.ToString());

video.PlayTheVideo();
Console.WriteLine(video.ToString());

video.StopTheVideo();
Console.WriteLine(video.ToString());

video.StopTheVideo();
Console.WriteLine(video.ToString());

video.PauseTheVideo();
Console.WriteLine(video.ToString());

video.PlayTheVideo();
Console.WriteLine(video.ToString());

video.PlayTheVideo();
Console.WriteLine(video.ToString());

video.PauseTheVideo();
Console.WriteLine(video.ToString());

PushButton btn = new PushButton();
Console.WriteLine(btn.ToString());
//btn.Display();
