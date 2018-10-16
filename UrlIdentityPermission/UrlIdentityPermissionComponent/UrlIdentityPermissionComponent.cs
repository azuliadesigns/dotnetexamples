//UrlIdentityPermissionComponent.cs

using System;
using System.Windows.Forms;
using System.Security.Permissions;

public class UrlIdentityPermissionComponent
{
	public static void DoSomethingForClient() 
	{
		UrlIdentityPermission urlidperm = 
			new UrlIdentityPermission(
			"file://C:/OI/NetSecurity/Chap8/UrlIdentityPermission/TrustedClient/TrustedClient.exe");
		urlidperm.Demand();

		//if we got this far then all is OK
		Console.WriteLine(
			"Client call permitted");
	}
}
