using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PZ_generatory.Quiz
{
    class TimerArc : Shape
    {

        public double Start
        {
            get { return (double)GetValue(StartProperty); }
            set { SetValue(StartProperty, value); }
        }

        public static readonly DependencyProperty StartProperty =
                      DependencyProperty.Register("Start", typeof(double), typeof(TimerArc),
                            new FrameworkPropertyMetadata(0D,
                            FrameworkPropertyMetadataOptions.AffectsRender));



        public double End
        {
            get { return (double)GetValue(EndProperty); }
            set { SetValue(EndProperty, value); }
        }

        public static readonly DependencyProperty EndProperty =
                        DependencyProperty.Register("End", typeof(double), typeof(TimerArc),
                            new FrameworkPropertyMetadata(0D,
                            FrameworkPropertyMetadataOptions.AffectsRender));





        protected override System.Windows.Media.Geometry DefiningGeometry
        {
            get { return GetGeometry(); }
        }

        protected override System.Windows.Size MeasureOverride(Size constraint)
        {
            return base.MeasureOverride(constraint);
        }

        protected override System.Windows.Size ArrangeOverride(Size finalSize)
        {
            return base.ArrangeOverride(finalSize);
        }


        private Geometry GetGeometry()
        {
            Point startpoint = GetPoint(Math.Min(Start, End));
            Point endpoint = GetPoint(Math.Max(Start, End));

            /* To draw the arc in perfect way instead of seeing it as Big arc */
            Size arc = new Size(Math.Max(0, (this.RenderSize.Width - this.StrokeThickness) / 2),
                                Math.Max(0, (this.RenderSize.Height - this.StrokeThickness) / 2));

            bool isgreaterthan180 = Math.Abs(End - Start) > 180;

            StreamGeometry strmgeometry = new StreamGeometry();
            using (StreamGeometryContext drawcontext = strmgeometry.Open())
            {
                drawcontext.BeginFigure(startpoint, false, false);
                drawcontext.ArcTo(endpoint, arc, 0, isgreaterthan180, SweepDirection.Counterclockwise, true, false);
            }

            double translate = this.StrokeThickness / 2;
            strmgeometry.Transform = new TranslateTransform(translate, translate);

            return strmgeometry;
        }

        private Point GetPoint(double angle)
        {
            /* rad = angle * pi/180 */
            double rad = angle * (Math.PI / 180);

            double xrad = (this.RenderSize.Width - this.StrokeThickness) / 2;
            double yrad = (this.RenderSize.Height - this.StrokeThickness) / 2;

            /* Find the point with radius and angle */
            /* X=  centerX + Raidus * Sin(rad) */
            /* Y = centerY + Radius * Cos(rad) */

            double x = xrad + xrad * Math.Sin(rad);
            double y = yrad + yrad * Math.Cos(rad);

            return new Point(x, y);
        }


    }

}
