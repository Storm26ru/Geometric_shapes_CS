using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Geometric_shapes
{

	class Program
	{
		static void Main(string[] args)
		{
			Graphics graphics = Graphics.FromHwnd(GetConsoleWindow());
			PaintEventArgs e = new PaintEventArgs(graphics, 
				               new System.Drawing.Rectangle(Console.WindowLeft, Console.WindowTop, Console.WindowWidth, Console.WindowHeight));
			//new Rectangle(100, 80, 300, 25, Color.Blue).Print(e);
			//new Square(80, 300, 150, Color.Red).Print(e);
			//new Ellipse(50, 300, 280, Color.Yellow).Print(e);
			//new EquilateralTriangle(100, 350, 410, Color.Green).Print(e);
			ShapeFactory().Print(e); 
		}
		static public Shape ShapeFactory()
		{
			Random rnd = new Random((int)DateTime.Now.Ticks);
			switch (rnd.Next(1,5))
			{
				case 1: return new Rectangle(120, 80, 300, 25, Color.Blue);
				case 2: return new Square(80, 300, 25, Color.Red);
				case 3: return new Ellipse(50, 300, 25, Color.Yellow);
				case 4: return new EquilateralTriangle(100, 350, 25, Color.Green);
				default:return null;
			}
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		

	}
}
