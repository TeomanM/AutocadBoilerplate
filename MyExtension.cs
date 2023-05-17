using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ExtensionApplication(typeof(AutocadBoilerplate.MyExtension))]
[assembly: CommandClass(typeof(AutocadBoilerplate.MyExtension))]

namespace AutocadBoilerplate
{
    public class MyExtension : IExtensionApplication
    {
        public void Initialize()
        {

        }

        public void Terminate()
        {

        }

        [CommandMethod("TEST")]
        public void MyFirstCommand()
        {
            // Create utility instance
            AcadUtils utils = new AcadUtils();

            // Write something to console
            utils.Ed.WriteMessage("\nHello World!");


            // Start a transaction
            Transaction trans = utils.Manager.StartTransaction();

            using (trans)
            {
                // Draw a line
                Point3d point1 = new Point3d(0, 0, 0);
                Point3d point2 = new Point3d(100, 0, 0);

                Line line = new Line(point1, point2);

                // Add to block table (see DatabaseExtensions.cs)
                line.AddToModelSpace();

                trans.Commit();
            }
            

        }



    }
}
