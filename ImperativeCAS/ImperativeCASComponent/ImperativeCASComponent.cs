//ImperativeCASComponent.cs

using System;
using System.Security;
using System.Collections;
using System.Security.Policy;

using System.Windows.Forms;

public class ImperativeCASComponent
{
	//this method only works for TrustedClient.exe
	public static void DoSomethingForClient() 
	{
		Console.WriteLine(
			"DoSomethingForClient called");

		//obtain appdomain security evidence
		Evidence evidence = 
			AppDomain.CurrentDomain.Evidence;

		//obtain evidence enumerator
		IEnumerator enumerator = evidence.GetEnumerator();

		bool trustworthy = false; //assume the worst
		while (enumerator.MoveNext()) //walk thru evidence
		{
			object item = enumerator.Current;

			//test to see if Url is acceptable
			Type type = item.GetType();
			if (type == typeof(System.Security.Policy.Url))
			{
				String strUrl = 
					((Url)item).Value.ToString();
				if (strUrl.EndsWith("TrustedClient.exe"))
				{
					trustworthy = true; //good news
					break;
				}
			}
		}

		//throw exception if no good evidence found
		if (!trustworthy)
			throw new SecurityException(
				"Client is not trustworthy");

		//if we got this far then all went OK
		Console.WriteLine(
			"Permitted: Client is trustworthy");
	}
}
