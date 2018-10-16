//PermissionRequest.cs

using System;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

[assembly:UIPermission(
	SecurityAction.RequestMinimum,
	Clipboard=UIPermissionClipboard.AllClipboard)]
[assembly:UIPermission(
	SecurityAction.RequestOptional, 
	Unrestricted=true)]
[assembly:UIPermission(
	SecurityAction.RequestRefuse,
	Window=UIPermissionWindow.AllWindows)]

public class PermissionRequest 
{
	public static void Main() 
	{
		Console.WriteLine("Calling TryClipboardAccess");
		TryClipboardAccess();

		Console.WriteLine("Calling TryWindowAccess");
		TryWindowAccess();

		Console.Write("Press any key");
		Console.Read();
	}

	private static void TryClipboardAccess() 
	{
		try 
		{
			Clipboard.SetDataObject(
				"TryClipboardAccess", true);
		} 
		catch (SecurityException se) 
		{
			Console.WriteLine(se.Message);
		} 
	}
	private static void TryWindowAccess() 
	{
		try 
		{
			MessageBox.Show("TryWindowAccess");
		} 
		catch (SecurityException se) 
		{
			Console.WriteLine(se.Message);
		} 
	}
}
