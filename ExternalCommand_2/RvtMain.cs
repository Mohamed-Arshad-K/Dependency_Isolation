using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

using EMath.Lib;

namespace ExternalCommand_2
{
    [Transaction(TransactionMode.Manual)]
    public class RvtMain : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            double sub = MathsLib.Sub(20, 10);

            TaskDialog.Show("Info", sub.ToString());


            return Result.Succeeded;
        }
    }
}
