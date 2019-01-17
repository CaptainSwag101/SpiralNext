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
            FilterArgs(args);
        }

        void FilterArgs(string [] args)
        {
            for (int i = 0; i < args.Length; i++)
            {

                if (args[i].StartsWith("--"))
                {
                    string arg = args[i].Substring(2, args[i].Length - 2);

                    switch (arg)
                    {
                        case "disable-update-check":
                        case "u":
                            disableUpdateCheck = true;
                            break;

                        case "tool":
                        case "t":
                            isTool = true;
                            break;

                        case "time-commands":
                        case "tc":
                            timeCommands = true;
                            break;

                        case "suppress":
                        case "s":
                            silenceOutput = true;
                            break;

                        case "ansi":
                        case "a":
                            ansiEnabled = true;
                            break;

                        case "disable-ansi":
                        case "p":
                            ansiEnabled = false;
                            break;
                    }

                }

            }
        }

    }
}
