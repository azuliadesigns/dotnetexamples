//WalkingThruEvidence.cs

using System;
using System.Collections;
using System.Security.Policy;
using System.Text;

class WalkingThruEvidence
{
	static void Main(string[] args)
	{
		//obtain appdomain security evidence
		Evidence evidence = 
			AppDomain.CurrentDomain.Evidence;

		//obtain evidence enumerator
		IEnumerator enumerator = evidence.GetEnumerator();

		//walk thru evidence
		while (enumerator.MoveNext()) 
		{
			object item = enumerator.Current;

			//display the evidence
			Type type = item.GetType();
			Console.WriteLine(type.Name + ": ");
			if (type == typeof(Url))
			{
				Console.WriteLine(
					"   Value: " + 
					((Url)item).Value);
			}
			if (type == typeof(Zone))
			{
				Console.WriteLine(
					"   SecurityZone: " + 
					((Zone)item).SecurityZone);
			}
			if (type == typeof(Hash))
			{
				Console.WriteLine(
					"   MD5: " + 
					BitConverter.ToString(((Hash)item).MD5));
				Console.WriteLine(
					"   " + "SHA1: " + 
					BitConverter.ToString(((Hash)item).SHA1));
			}
			if (type == typeof(StrongName))
			{
				Console.WriteLine(
					"   Name: " + 
					((StrongName)item).Name);
				Console.WriteLine(
					"   Version: " + 
					((StrongName)item).Version);
				Console.WriteLine(
					"   PublicKey: " + 
					((StrongName)item).PublicKey);
			}
			if (type == typeof(Site))
			{
				Console.WriteLine(
					"   Name: " + 
					((Site)item).Name);
			}
		}

		Console.WriteLine("Press any key to continue");
		Console.ReadLine();
	}
}
