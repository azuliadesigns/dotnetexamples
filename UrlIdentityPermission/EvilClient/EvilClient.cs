//EvilClient.cs

using System;
using System.Security;

class EvilClient
{
	static void Main(string[] args)
	{
		//NOTE: need ref to ImperativeCASComponent.dll

		//try to call on the component
		try
		{
			UrlIdentityPermissionComponent.
				DoSomethingForClient();
		}
		catch (SecurityException se)
		{
			Console.WriteLine("Error: " + se.Message);
		}
	}
}
