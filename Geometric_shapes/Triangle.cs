using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometric_shapes
{
	abstract class Triangle:Shape
	{
		public Triangle(int x, int y, Color color):base(x,y,color) { }
		public abstract double GetHeight();
		public override void Print(PaintEventArgs e)
		{
			base.Print(e);
		}
		public override string ToString()
		{
			return $"Treangle height:{GetHeight()}\n\n{base.ToString()}";
		}
	}
}
