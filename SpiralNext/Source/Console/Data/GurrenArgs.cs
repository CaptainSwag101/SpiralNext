using System;

namespace SpiralNext.Console.Data
{
    class GurrenArgs
    {
        public bool disableUpdateCheck = false;
        public bool isTool = false;
        public bool timeCommands = false;
        public bool silenceOutput = false;
        public bool ansiEnabled = false;
        public string[] rawargs;

        public GurrenArgs(string[] args)
        {
            rawargs = args;
        }

    }
}
