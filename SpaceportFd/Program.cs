// See https://aka.ms/new-console-template for more information

using CHAOS;
using CHAOS.Som;
using System.Runtime.InteropServices;

namespace SpaceportFdApp;
internal class Program
{
    private static void Main(string[] args)
    {
        TitleSplash();

        //initializing the simulation manager 
        CSimulationManager simulationManager = new();
        CSpaceportFd spaceportFd = simulationManager.federate;

        //enabling logging for debugging and joining the federation
        spaceportFd.LogLevel = Racon.LogLevel.ALL;
        spaceportFd.StatusMessageChanged += (object sender, EventArgs e) => Console.WriteLine((sender as CSpaceportFd).StatusMessage + Environment.NewLine);
        spaceportFd.InitializeFederation(spaceportFd.FederationExecution);

        CSpaceportHlaObject spaceport = new(spaceportFd.Som.SpaceportOC, "SOL-3", new LocationType(1,1,1),StationtypeType.Orbital, "SL3");
        spaceportFd.Spaceport = spaceport;

        Console.WriteLine("SpaceportFd is live!");

        while (true)
        {
            try { spaceportFd.Run(); }
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


    
