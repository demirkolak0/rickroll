using System;
using System.Diagnostics;
using System.Runtime;
using System.IO;
namespace Repeat
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
		}
	}
}