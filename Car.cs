using System;
public class Car
{
    public static void Main()
    {
        Ciaz ciaz = new Ciaz();
        Console.WriteLine("Car model is : {0}", ciaz.modelName);
        ciaz.PetrolEngine();
        ciaz.Start();
        ciaz.Accerlate();
        ciaz.Stop();
        

        CheavyBeat cheavyBeat = new CheavyBeat();
        Console.WriteLine("Car model is : {0}", cheavyBeat.modelName);
        cheavyBeat.DieselEngine();
        cheavyBeat.Start();
        cheavyBeat.Accerlate();
        cheavyBeat.Stop();

        TataNexon tataNexon = new TataNexon();
        Console.WriteLine("Car model is : {0}", tataNexon.modelName);
        tataNexon.PetrolEngine();
        tataNexon.Start();
        tataNexon.Accerlate();
        tataNexon.Stop();
    }
}