//EncryptedHash.cs

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class EncryptedHash
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
         
		//Create MD5 hash bytes from plaintext bytes
		MD5CryptoServiceProvider md5 = 
			new MD5CryptoServiceProvider();
		byte[] hashBytes = 
			md5.ComputeHash(plaintextBytes);

		//display plaintext hash bytes
		Console.WriteLine(
			"Hash bytes of plaintext string:\n" + 
			BitConverter.ToString(hashBytes));

		//encrypt hash bytes using DES
		SymmetricAlgorithm sa = DES.Create();
		MemoryStream msEncrypt = 
			new MemoryStream();
		CryptoStream csEncrypt = new CryptoStream(
			msEncrypt,
			sa.CreateEncryptor(),
			CryptoStreamMode.Write);
		csEncrypt.Write(hashBytes, 
			0, hashBytes.Length);
		csEncrypt.Close();
		byte[] encryptedHashBytes = msEncrypt.ToArray();
		msEncrypt.Close();

		//display encrypted hash bytes
		Console.WriteLine(
			"Encrypted hash bytes of plaintext string:\n" +
			BitConverter.ToString(encryptedHashBytes));

		//decrypt hash bytes using DES
		MemoryStream msDecrypt = 
			new MemoryStream(encryptedHashBytes);
		CryptoStream csDecrypt = new CryptoStream(
			msDecrypt, 
			sa.CreateDecryptor(),
			CryptoStreamMode.Read);
		byte[] decryptedHashBytes = 
			new Byte[encryptedHashBytes.Length];
		csDecrypt.Read(decryptedHashBytes, 
			0, encryptedHashBytes.Length);
		csDecrypt.Close();
		msDecrypt.Close();

		//display decrypted hash bytes
		Console.WriteLine(
			"Decrypted hash bytes of plaintext string:\n" + 
			BitConverter.ToString(decryptedHashBytes));

		//compare original and decrypted hash bytes
		bool match = true;
		for (int i=0; i<hashBytes.Length; i++)
		{
			if(hashBytes[i] != decryptedHashBytes[i])
			{
				match = false;
				break;
			}
		}
		if(match)
			Console.WriteLine(
				"The hash values match!");
		else
			Console.WriteLine(
				"The hash values do not match!");
	}
}
