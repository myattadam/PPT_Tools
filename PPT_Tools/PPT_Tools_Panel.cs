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

        List<PowerPoint.Shape> selected;

        public PPT_Tools_Panel() => InitializeComponent();

        private void PPT_Tools_Panel_Load(object sender, EventArgs e) { }

        private void BtnCopyLayout_Click(object sender, EventArgs e)
        {
            selected = Tools.SelectedShapes;
            selected.ForEach(shape => TxtOutput.Text += shape.Name + "\n");
        }

        private void BtnPasteLayout_Click(object sender, EventArgs e)
        {

            var pattern = new List<Rect>();
            var current = Tools.SelectedShapes;

            selected.ForEach(shape => pattern.Add(new Rect(shape)));            

            for(var i = 0; i < current.Count; i++)
            {
                pattern[i % pattern.Count].Apply(current[i]);
            }
        }
    }



    public static class Tools
    {
        public static PowerPoint.Application Application { get => Globals.ThisAddIn.Application; }
        
        public static List<PowerPoint.Shape> SelectedShapes {
            get {
                var selected = Application.ActiveWindow.Selection;
                var shapes = new List<PowerPoint.Shape>();

                if (selected.Type == PowerPoint.PpSelectionType.ppSelectionShapes)
                {
                    foreach (var sh in selected.ShapeRange) shapes.Add((PowerPoint.Shape)sh);
                }

                return shapes;
            }
        }
    }

}
