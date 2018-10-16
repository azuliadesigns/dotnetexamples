//TrustedClient.cs

using System;
using System.Security;

class TrustedClient
{
	static void Main(string[] args)
	{
		//NOTE: need ref to ImperativeCASComponent.dll

		//try to call on the component
		try
		{
			ImperativeCASComponent.DoSomethingForClient();
		}
		catch (SecurityException se)
		{
			Console.WriteLine(
				"SecurityException: " + se.Message);
		}
	}

}
