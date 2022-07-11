#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace REVITAddinAcadmey_02
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialog.Show("REVIT Addin Acadmey v02", "REVIT Addin Acadmey v2022-07-10 9:47PM");
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("REVIT Addin Acadmey v02", "Exiting REVIT Addin Acadmey v2022-07-10 9:47PM");
            return Result.Succeeded;
        }
    }
}
