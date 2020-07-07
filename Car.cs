using System;
public class Car :IVehicle
{
    public String Start()
    {
        return string.Format("Your Vehicle is started");
    }
    public string Accerlate()
    {
        return string.Format("Your vehicle is running");
    }
    public string Stop()
    {
       return string.Format("Your vehicle is stopped");
    }
}