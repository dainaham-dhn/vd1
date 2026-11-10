using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _10_11_26
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            ICollection<ElementId> selectElement = uidoc.Selection.GetElementIds();
            int totalCount = selectElement.Count;
            MessageBox.Show("Ban da chon: " + totalCount.ToString() + "elements");

            //phat trien code
            string IdList = "Danh sach ID cua doi tuong:\n";
            foreach (ElementId e1 in selectElement)
            {
                IdList = IdList + e1.ToString() + "\n";

            }
            MessageBox.Show(IdList);
            return Result.Succeeded;
        }

    }
}
