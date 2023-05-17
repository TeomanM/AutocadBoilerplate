using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocadBoilerplate
{
    internal class AcadUtils
    {
        public Document Doc => Application.DocumentManager.MdiActiveDocument;
        public Database Db => Doc.Database;
        public Editor Ed => Doc.Editor;
        public Autodesk.AutoCAD.DatabaseServices.TransactionManager Manager => Db.TransactionManager;

        public AcadUtils()
        {

        }


    }
}
