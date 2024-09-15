using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometric_shapes
{
	abstract class Shape
	{
		protected static readonly int MIN_X = 10;
		protected static readonly int MIN_Y = 10;
		protected static readonly int MAX_X = 800;
		protected static readonly int MAX_Y = 600;
		protected static readonly int MIN_SIZE = 50;
		protected static readonly int MAX_SIZE = 600;
		
		int x;
		int y;

		public int X { get => x; set => x = value < MIN_X ? MIN_X : value > MAX_X ? MAX_X : value; }
		public int Y { get => y; set => y = value < MIN_Y ? MIN_Y : value > MAX_Y ? MAX_Y : value; }
		public Color Color { get; set; }

		//					Constructors
		public Shape(int x, int y,Color color)
		{
			X = x;
			Y = y;
			Color = color;
		}

		//					Methods
		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw(PaintEventArgs e);
		public virtual void Print(PaintEventArgs e)
		{
			Console.WriteLine(this);
			this.Draw(e);
		}
		public override string ToString()
		{
			return $"Area:\t\t{GetArea()}\n\nPerimetr:\t{GetPerimeter()}\n\n";
		}
	}
}
