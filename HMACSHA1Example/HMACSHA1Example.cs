//HMACSHA1Example.cs

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class HMACSHA1Example
{
	public static void Main()
	{
		//get plaintext string from user
		Console.WriteLine("Enter a plaintext string:");
		String plaintextString = Console.ReadLine();

		//Convert plaintext string to byte array
		Byte[] plaintextBytes = 
			(new UnicodeEncoding()).GetBytes(
			plaintextString);    

		//Create keyed hash bytes from plaintext bytes
		byte[] key = new byte[16];
		HMACSHA1 hmac = new HMACSHA1(key);
		CryptoStream cs = new CryptoStream(
			Stream.Null, hmac, CryptoStreamMode.Write);
		cs.Write(
			plaintextBytes, 0, plaintextBytes.Length);
		cs.Close();
		byte[] keyedHashBytes = hmac.Hash;

		//display keyed hash bytes
		Console.WriteLine(
			"Keyed hash bytes of plaintext string:\n" + 
			BitConverter.ToString(keyedHashBytes));
	}
}
