using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;

namespace PPT_Tools
{

    public partial class ThisAddIn
    {
        private PPT_Tools_Panel panel;
        private CustomTaskPane taskpane;

/*        public PowerPoint.ShapeRange Selection()
        {
            if(Application.ActiveWindow.Selection.Type == PowerPoint.PpSelectionType.ppSelectionShapes) return 
        }*/

        private void ThisAddIn_Startup(object sender, System.EventArgs e)            
        {
            panel = new PPT_Tools_Panel();
            taskpane = this.CustomTaskPanes.Add(panel, "PPT tools");
            taskpane.Visible = true;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
