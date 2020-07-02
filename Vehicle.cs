using System;
public class Vehicle :IEngine
{
    public void Start()
    {
        Console.WriteLine("Your Vehicle is started");
    }
    public void Accerlate()
    {
        Console.WriteLine("Your vehicle is running");
    }
    public void Stop()
    {
        Console.WriteLine("Your vehicle is stopped");
    }
}