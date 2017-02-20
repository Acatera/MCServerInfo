using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace serverInfo
{
    public class LineChart : System.Windows.Forms.Panel
    {
        public int MaxValue = 10;
        public int MaxCount = 4 * 12;

        public SByte[] data;
        public Point[] points;
        public String[] names;

        private ToolTip tooltip;
        private int pointOffset;

        public LineChart()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                           System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);

            data = new SByte[this.MaxCount];
            points = new Point[this.MaxCount];
            names = new String[this.MaxCount];

            tooltip = new ToolTip();

            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DoPaint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoMouseMove);
        }

        public void AppendData(sbyte value, string namesOnline)
        {
            ShiftLeft(data);
            data[data.Length - 1] = (sbyte)value;

            ShiftLeft(names);
            names[names.Length - 1] = namesOnline;

            pointOffset = (int)Math.Round((double)(this.Width / this.MaxCount));
            CalcPoints();
        }

        private void ShiftLeft(Array data)
        {
            Array.Copy(data, 1, data, 0, data.Length - 1);
        }

        private void CalcPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == null)
                    points[i] = new Point();

                points[i].X = (i + 1) * pointOffset;
                points[i].Y = this.Height - (this.Height / this.MaxValue) * this.data[i];
            }
        }

        private void DoPaint(object sender, PaintEventArgs e)
        {
            LineChart p = sender as LineChart;
            var g = e.Graphics;
            Brush brush = new SolidBrush(Color.LightGreen);

            for (int i = 0; i < p.points.Length - 1; i++)
            {
                g.DrawLine(new Pen(brush), p.points[i], p.points[i + 1]);
            }
        }

        private void DoMouseMove(object sender, MouseEventArgs e)
        {
            byte offset = 4;

            for (int i = 0; i < this.points.Length; i++)
            {
                if ((Math.Abs(e.X - this.points[i].X) <= offset) && (Math.Abs(e.Y - this.points[i].Y) <= offset))
                {
                    string tooltipText = String.Format("Online: {0} \n[{1}]", this.data[i], this.names[i]);
                    if (this.tooltip.GetToolTip(this) != tooltipText)
                        this.tooltip.SetToolTip(this, tooltipText);
                }
            }
        }

    }
}
