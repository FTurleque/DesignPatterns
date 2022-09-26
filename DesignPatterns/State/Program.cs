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
Console.WriteLine("\n--------------------------------------------------\n");

PushButton btn = new PushButton();
Console.WriteLine("\n--------------------Enable------------------------------");
btn.Enable();
Console.WriteLine("\n--------------------Disable------------------------------");
btn.Disable();
Console.WriteLine("\n--------------------Press------------------------------");
btn.Press();
Console.WriteLine("\n--------------------Enable------------------------------");
btn.Enable();
Console.WriteLine("\n--------------------Press------------------------------");
btn.Press();
//btn.Display();
