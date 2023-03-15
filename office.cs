using System;
using  System.Media;
using System.Threading;
using System.Runtime.InteropServices;
namespace Rickroll
{
	class Program
	{
		[DllImport("Kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();
		[DllImport("User32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
		static void Main(string[] args)
		{ 	
			IntPtr hWnd = GetConsoleWindow();
			if(hWnd != IntPtr.Zero)
			{
				ShowWindow(hWnd, 0);
			}
			SoundPlayer rickroll = new SoundPlayer(@"rickroll.wav");
			rickroll.Load();
			rickroll.PlayLooping();
			Console.ReadKey();
		}
	}
}
