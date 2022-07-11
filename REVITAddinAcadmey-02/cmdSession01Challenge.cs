#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

#endregion

namespace REVITAddinAcadmey_02
{
    [Transaction(TransactionMode.Manual)]
    public class cmdSession01Challenge : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            TaskDialog.Show("Hello", "Starting the FIZZBUZZ process");

            int range = 20;
            List<string> resultlist = new List<string>();

            for(int i=1; i<=range; i++)
            {
                string result = "";

                if (i % 3 == 0)
                {
                    result = "FIZZ";
                }

                if (i % 5 == 0)
                {
                    result = result + "BUZZ";
                }

                if (i%3 != 0 && i%5 != 0)
                {
                    result = i.ToString();
                }

                resultlist.Add(result);

                TextNode curNote = TextNode.Create(doc, doc.ActiveView.Id, Point, "This is my text")

                //TextNode curNote = TextNode.Create(doc);

                //TaskDialog.Show("RESULT", result);

                //Debug.Print(result);


                /*
                 if (i % 3 == 0 && i % 5 == 0)
                {
                    result = "FIZZBUZZ"
                }
                */

            }

            
            return Result.Succeeded;
        }
    }
}
