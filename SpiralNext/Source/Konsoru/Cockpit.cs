using System;

namespace SpiralNext.Konsoru
{
    class Cockpit
    {
        static void Main(string[] args)
        {
            Data.GurrenArgs gurrenArgs = new Data.GurrenArgs(args);

            if (gurrenArgs.isTool)
            {
                var instance = new CockpitMechanic(gurrenArgs);
                instance.start();
                Environment.Exit(instance.currentExitCode);
            }
            else
            {
                var instance = new CockpitPilot(gurrenArgs);
                instance.start();
                Environment.Exit(instance.currentExitCode);
            }
        }
       
    }
}
