using AutocadBoilerplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodesk.AutoCAD.DatabaseServices
{
    public static class DatabaseExtensions
    {
        public static ObjectId AddToModelSpace(this Entity ent)
        {
            AcadUtils utils = new AcadUtils();
            Transaction trans = utils.Manager.TopTransaction;

            // Don't check for entity's fields before they are created; just check the transaction.
            if (trans != null)
            {
                BlockTableRecord blockTableRec = trans.GetObject(utils.Db.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;

                ObjectId id = blockTableRec.AppendEntity(ent);
                trans.AddNewlyCreatedDBObject(ent, true);
                return id;
            }
            return ObjectId.Null;
        }

    }
}
