using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using EMath.Lib;

namespace ExternalCommand_1
{
    [Transaction(TransactionMode.Manual)]
    public class RvtMain : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            double add = MathsLib.Add(10, 20);

            TaskDialog.Show("Info", add.ToString());

            return Result.Succeeded;
        }
    }
}
