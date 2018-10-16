//GenericPrincipal.cs

using System;
using System.Security;
using System.Security.Principal;
using System.Threading;

class GenericPrincipalExample
{
	public static void Main(string[] args)
	{
		//logon as TrustedUser and attempt work
		Console.WriteLine("Logon as TrustedUser");
		CustomLogon();
		AttemptWork();

		//logon as UntrustedUser and attempt work
		Console.WriteLine("Logon as UntrustedUser");
		CustomLogon();
		AttemptWork();
	}
	static void AttemptWork()
	{
		try
		{
			AttemptCodeAsUser();
		}
		catch (SecurityException se)
		{
			Console.WriteLine(se.Message);
		}
	}
	static void CustomLogon()
	{
		//loop until valid user entered
		while (true)
		{
			Console.Write(
				"Enter username: ");
			strUserName = Console.ReadLine();
			if (strUserName.Equals("TrustedUser"))
				break;
			if (strUserName.Equals("UntrustedUser"))
				break;
			Console.WriteLine(
				strUserName + " is not a valid user.\n");
			strUserName = null;
		} 

		//create a generic identity object
		IIdentity myGenericIdentity = 
			new GenericIdentity(
			strUserName, "MyAuthenticationType");

		//create a generic principal object
		String[] roles = null; //not used in this example
		GenericPrincipal myGenericPrincipal = 
			new GenericPrincipal(myGenericIdentity, roles);

		//attach generic principal to current thread
		Thread.CurrentPrincipal = myGenericPrincipal;

		//show generic principal contents
		Console.WriteLine(
			"\nUser name: {0}", 
			myGenericPrincipal.Identity.Name);
		Console.WriteLine(
			"Authenticated: {0}", 
			myGenericPrincipal.Identity.IsAuthenticated);
		Console.WriteLine(
			"Authentication type: {0}", 
			myGenericPrincipal.Identity.AuthenticationType);
	}

	static void AttemptCodeAsUser ()
	{
		//get current principal object
		IPrincipal principle = Thread.CurrentPrincipal;

		if (!principle.Identity.Name.Equals("TrustedUser"))
		{
			throw new SecurityException(
				strUserName + " NOT PERMITTED to proceed.\n");
		}
		Console.WriteLine(
			strUserName + " is PERMITTED to proceed.\n");
	}

	//user name is used among methods
	static String strUserName;
}
