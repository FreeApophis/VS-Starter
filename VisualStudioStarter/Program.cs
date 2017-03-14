using System;
using System.Collections.Generic;

namespace VisualStudioStarter
{
    static class Program

    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                var starter = new VisualStudioInterop(VisualStudioHelper.VisualStudioVersion.VisualStudio2015);

                starter.OpenFile(GetFileNameArgument(args), GetFileLineArgument(args));

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                Console.Write(e.StackTrace);
            }
        }

        private static int GetFileLineArgument(IReadOnlyList<string> args)
        {
            if (args.Count < 1) return 0;

            int fileline;
            int.TryParse(args[1], out fileline);
            return fileline;
        }

        private static string GetFileNameArgument(IReadOnlyList<string> args)
        {
            return args.Count < 1 ? "" : args[0];
        }
    }
}