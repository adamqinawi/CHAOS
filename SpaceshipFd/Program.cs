using CHAOS.Som;
using CHAOS;

internal class Program
{
    private static void Main(string[] args)
    {
        TitleSplash();

        //initializing the simulation manager 
        CSimulationManager simulationManager = new();
        CSpaceshipFd spaceshipFd= simulationManager.federate;

        //enabling logging for debugging and joining the federation
        spaceshipFd.LogLevel = Racon.LogLevel.ALL;
        spaceshipFd.StatusMessageChanged += (object sender, EventArgs e) => Console.WriteLine((sender as CSpaceshipFd).StatusMessage + Environment.NewLine);
        spaceshipFd.InitializeFederation(spaceshipFd.FederationExecution);

        CSpaceshipHlaObject spaceship = new(spaceshipFd.Som.SpaceshipOC, new LocationType(4,4,4), "Costa Stellaria", "CSA", "SL3",ShipclassType.Passenger, 20);
        spaceshipFd.Spaceship = spaceship;

        Console.WriteLine("SpaceshipFd is live!");

        spaceshipFd.sendMessage("SL3", "Hello World!");

        while (true)
        {
            try { 
                spaceshipFd.Run();
                
                
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }
    }

    // function to display ASCII Art and name
    public static void TitleSplash()
    {
        Console.WriteLine(" ________  ___  ___  ________  ________  ________      \r\n|\\   ____\\|\\  \\|\\  \\|\\   __  \\|\\   __  \\|\\   ____\\     \r\n\\ \\  \\___|\\ \\  \\\\\\  \\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|_    \r\n \\ \\  \\    \\ \\   __  \\ \\   __  \\ \\  \\\\\\  \\ \\_____  \\   \r\n  \\ \\  \\____\\ \\  \\ \\  \\ \\  \\ \\  \\ \\  \\\\\\  \\|____|\\  \\  \r\n   \\ \\_______\\ \\__\\ \\__\\ \\__\\ \\__\\ \\_______\\____\\_\\  \\ \r\n    \\|_______|\\|__|\\|__|\\|__|\\|__|\\|_______|\\_________\\\r\n                                           \\|_________|\r\n                                                       \r\n                                                       \r\n\r\n");
        Console.WriteLine("Cosmic Hauling And Operations Simulation");
    }
}