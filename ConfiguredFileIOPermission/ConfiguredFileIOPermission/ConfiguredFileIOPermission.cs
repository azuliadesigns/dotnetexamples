//ConfiguredFileIOPermission.cs

//must add ref to AvoidIO.dll
//must add ref to AttemptIO.dll

using System;
using System.IO;
using System.Security.Permissions;
using System.Security;

class FileIOPermissionExample
{
	//PermissionSetAttribute that denies the permissions
	//defined in the MyPermissionSet.xml app config file
	[PermissionSetAttribute(
		 SecurityAction.Deny,
		 File="C:\\OI\\NetSecurity\\Chap8\\ConfiguredFileIOPermission\\ConfiguredFileIOPermission\\MyPermissionSet.xml")]
	public static void Main()
	{

		try
		{
			AvoidIO avoidio = new AvoidIO();
			avoidio.DoNoFileIO();

			AttemptIO attemptio = new AttemptIO();
			attemptio.DoFileIO();
		}
		catch(SecurityException se)
		{
			Console.WriteLine(se.Message);
		}
	}
}
