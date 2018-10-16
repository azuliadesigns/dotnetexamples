//DeclarativeCASComponent.cs

using System;

using System.Security;
using System.Security.Permissions;

public class UrlIdentityPermissionComponent
{
	[UrlIdentityPermission(
		 SecurityAction.LinkDemand, 
		 Url="file://C:/OI/NetSecurity/Chap8/DeclarativeCAS/TrustedClient/TrustedClient.exe")]
	public static void DoSomethingForClient() 
	{
		//if we got this far then all is OK
		Console.WriteLine(
			"Client call permitted");
	}
}