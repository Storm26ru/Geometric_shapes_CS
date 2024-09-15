using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometric_shapes
{
	class Ellipse:Shape
	{
		public double Radius { get; set; }
		public Ellipse(double radius,int x, int y,Color color):base(x,y,color)
		{
			Radius = radius;
		}
		public override double GetArea()
		{
			return Math.PI * Radius * Radius;
		}
		public override double GetPerimeter()
		{
			return 2 * Math.PI * Radius;
		}
		public double GetDiametr()
		{
			return Radius * 2;
		}
		public override void Draw(PaintEventArgs e)
		{
			e.Graphics.FillEllipse(new SolidBrush(Color), X, Y, (float)GetDiametr(), (float)GetDiametr());
		}
		public override void Print(PaintEventArgs e)
		{
			Console.WriteLine($"\t{this.GetType().ToString().Split('.').Last()}\n");
			base.Print(e);
		}
		public override string ToString()
		{
			return $"Radius:\t\t{Radius}\n\nDiametr:\t{GetDiametr()}\n\n{base.ToString()}";
		}
	}
}
