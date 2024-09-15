using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;


namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindows();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			Rectangle rectangle = new Rectangle(Console.WindowLeft, Console.WindowTop, Console.WindowWidth, Console.WindowHeight);
			PaintEventArgs e = new PaintEventArgs(graphics, rectangle);
			
		}
		[DllImport("kernel32.dll")]
		public static extern bool GetStdHandle(int nStdHadle);
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindows();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);

	}
}
