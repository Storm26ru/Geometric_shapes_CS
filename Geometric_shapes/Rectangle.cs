using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Geometric_shapes
{
	class Rectangle:Shape
	{
		double whidht;
		double height;

		public double Whidht { get => whidht; set => whidht = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value; }
		public double Height { get => height; set => height = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value; }

		//					Constructors
		public Rectangle(double whidht,double height, int x, int y,Color color):base(x, y,color)
		{
			Whidht = whidht;
			Height = height;
		}

		//					Methods
		public override double GetArea()
		{
			return Whidht * Height;
		}
		public override double GetPerimeter()
		{
			return (Whidht + Height) * 2;
		}
		public override void Draw(PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(Color), X, Y, (float)Whidht, (float)Height);
		}
		public override void Print(PaintEventArgs e)
		{
			Console.WriteLine($"\t{this.GetType().ToString().Split('.').Last()}\n");
			base.Print(e);
		}
		public override string ToString()
		{
			return $"Whidht:\t\t{Whidht}\n\nHeight:\t\t{Height}\n\n{base.ToString()}";
		}

	}
}
