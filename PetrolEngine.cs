using System;
public class PetrolEngine : IEngine
{
    public override String Engine()
    {
        return String.Format("Your vehicle is running with petrol");
    }
}