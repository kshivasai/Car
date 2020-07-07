using System;
public class DiselEngine :IEngine
{
    public override String Engine()
    {
        return string.Format("Your vehicle is running with Disel");
    }
}