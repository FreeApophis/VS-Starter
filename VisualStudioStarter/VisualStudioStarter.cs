namespace VisualStudioStarter
{
    internal class VisualStudioInterop
    {
        private readonly VisualStudioHelper.VisualStudioVersion _version;

        internal VisualStudioInterop(VisualStudioHelper.VisualStudioVersion version)
        {
            _version = version;
        }

        internal void OpenFile(string file, int line)
        {
            EnvDTE80.DTE2 dte2 = null;
            dte2 = System.Runtime.InteropServices.Marshal.GetActiveObject(VisualStudioHelper.ToProgramId(_version)) as EnvDTE80.DTE2;
            dte2.MainWindow.Activate();

            EnvDTE.Window window = dte2.ItemOperations.OpenFile(file, EnvDTE.Constants.vsViewKindTextView);

            var selection = dte2.ActiveDocument.Selection as EnvDTE.TextSelection;
            selection?.GotoLine(line, true);

        }

    }
}
