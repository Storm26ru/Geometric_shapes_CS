using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geometric_shapes
{
	class EquilateralTriangle:Triangle
	{
		public double Side { get; set; }
		public EquilateralTriangle(double side, int x, int y, Color color):base(x,y,color)
		{
			Side = side;
		}
		public override double GetHeight()
		{
			return (Side * Math.Sqrt(3)) / 2;
		}
		public override double GetArea()
		{
			return (Side * GetHeight()) / 2;
		}
		public override double GetPerimeter()
		{
			return Side * 3;
		}
		public override void Draw(PaintEventArgs e)
		{
			PointF[] point = new PointF[]{new PointF(X,Y), new PointF(X + (float)Side / 2, Y + (float)GetHeight()),
							  new PointF(X - (float)Side / 2, Y + (float)GetHeight())};
			e.Graphics.FillPolygon(new SolidBrush(Color),point);
		}
		public override void Print(PaintEventArgs e)
		{
			Console.WriteLine($"\t{this.GetType().ToString().Split('.').Last()}\n");
			base.Print(e);
		}
		public override string ToString()
		{
			return $"Side:\t\t{Side}\n\n{base.ToString()}";
		}
	}
}
