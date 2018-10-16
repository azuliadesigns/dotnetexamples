//AttemptIO.cs

using System;
using System.IO;

public class AttemptIO
{
	public void DoFileIO()
	{
		Console.WriteLine("DoFileIO called...");
		String text = "Here is some data to write";
		FileStream fs = new FileStream(
			"outputdata.txt",
			FileMode.Create, FileAccess.Write);
		StreamWriter sw = new StreamWriter(fs);
		sw.Write(text);
		sw.Close();
		fs.Close();
		Console.WriteLine(
			"Written to outputdata.txt: " + text);
	}
}
