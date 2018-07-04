using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using System.Diagnostics;

namespace PPT_Tools
{
    public struct Rect
    {
        public float Left { get; set; }
        public float Top { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public Rect(PowerPoint.Shape shape) { Left = shape.Left; Top = shape.Top; Width = shape.Width; Height = shape.Height; }
        public void Apply(PowerPoint.Shape shape) { shape.Left = Left; shape.Top = Top; shape.Width = Width; shape.Height = Height; }
    }


    public partial class PPT_Tools_Panel : UserControl
    {

        List<Rect> layout;

        public PPT_Tools_Panel() => InitializeComponent();

        private void PPT_Tools_Panel_Load(object sender, EventArgs e) { }

        private void BtnCopyLayout_Click(object sender, EventArgs e) => layout = Tools.GetLayout; 

        private void BtnPasteLayout_Click(object sender, EventArgs e)
        {
            if (Tools.Selection.Type == PowerPoint.PpSelectionType.ppSelectionShapes)
            {
                var i = 0;
                foreach (var shape in Tools.ShapeSelector) layout[i++ % layout.Count].Apply(shape);
            }
        }
    }



    public static class Tools
    {
        public static PowerPoint.Application Application { get => Globals.ThisAddIn.Application; }
        public static PowerPoint.Selection Selection { get => Application.ActiveWindow.Selection;  }
        public static _ShapeSelector ShapeSelector { get => new _ShapeSelector(); }

        public class _ShapeSelector
        {
            public IEnumerator<PowerPoint.Shape> GetEnumerator()
            {
                if (Selection.Type == PowerPoint.PpSelectionType.ppSelectionShapes)
                {
                    foreach (PowerPoint.Shape shape in Selection.ShapeRange) yield return shape;
                }
            }
        }

        public static List<Rect> GetLayout {
            get {
                var shapes = new List<Rect>();
                foreach (var shape in ShapeSelector) shapes.Add(new Rect(shape));
                return shapes;
            }
        }

    }

}
