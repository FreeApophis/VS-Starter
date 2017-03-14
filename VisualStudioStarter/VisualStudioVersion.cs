using System;

namespace VisualStudioStarter
{
    internal static class VisualStudioHelper
    {
        internal enum VisualStudioVersion
        {
            VisualStudio2008 = 9,
            VisualStudio2010 = 10,
            VisualStudio2012 = 11,
            VisualStudio2013 = 12,
            VisualStudio2015 = 14,
            VisualStudio2017 = 15,
        }

        internal static string ToProgramId(VisualStudioVersion programVersion)
        {
            switch (programVersion)
            {
                case VisualStudioVersion.VisualStudio2008:
                case VisualStudioVersion.VisualStudio2010:
                case VisualStudioVersion.VisualStudio2012:
                case VisualStudioVersion.VisualStudio2013:
                case VisualStudioVersion.VisualStudio2015:
                case VisualStudioVersion.VisualStudio2017:
                    return $"VisualStudio.DTE.{(int)programVersion}.0";
                default:
                    throw new ArgumentOutOfRangeException(nameof(programVersion), programVersion, null);
            }
        }
    }
}