//FileIOPermission.cs

//must add ref to AvoidIO.dll
//must add ref to AttemptIO.dll

using System;
using System.IO;
using System.Security.Permissions;
using System.Security;

class FileIOPermissionExample
{
	public static void Main()
	{
		FileIOPermission fiop = new FileIOPermission(
			PermissionState.Unrestricted);
		fiop.Deny();
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