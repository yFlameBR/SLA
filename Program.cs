﻿using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using IronBrew2;
using IronBrew2.Obfuscator;

namespace IronBrew2_CLI
{
	class Program
	{
		
		static void Main()
		{
			
			if (Directory.Exists("temp"))
				Directory.Delete("temp", true);
			Directory.CreateDirectory("temp");
			if (!IB2.Obfuscate("temp",  "out.lua", new ObfuscationSettings(), out string err))
			{
				Console.WriteLine("ERR: " + err);
				return;
			}

			File.Delete("out.lua");
			File.Move("temp/out.lua", "out.lua");
			Console.WriteLine("Done!");
		}
	}
}