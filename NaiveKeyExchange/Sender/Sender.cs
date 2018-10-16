//Sender.cs

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class SymmetricCryptoSender
{
	static void Main(string[] args)
	{
		//create original plaintext to encrypt
		Console.Write("Enter text to be encrypted: ");
		String strPlaintext = Console.ReadLine();

		Console.WriteLine("Plaintext: " + strPlaintext);

		//encrypt and send the plaintext string
		EncryptAndWrite(strPlaintext);
	}

	private static void EncryptAndWrite(String strPlaintext)
	{
		//create crypto provider using the default key
		SymmetricAlgorithm rijn = 
			SymmetricAlgorithm.Create();

		//create key and iv info output file streams
		FileStream fsKeyInfo = new FileStream(
			"..\\..\\..\\keyinfo.txt",
			FileMode.Create, FileAccess.Write);
		FileStream fsIVInfo = new FileStream(
			"..\\..\\..\\ivinfo.txt",
			FileMode.Create, FileAccess.Write);

		//write to key info
		fsKeyInfo.Write(rijn.Key, 0, rijn.Key.Length);
		fsIVInfo.Write(rijn.IV, 0, rijn.IV.Length);
		fsKeyInfo.Close();
		fsIVInfo.Close();

		//create output file for encrypted data
		FileStream fsData = new FileStream(
			"..\\..\\..\\ciphertext.txt",
			FileMode.Create, FileAccess.Write);

		//establish crypto stream
		CryptoStream csData = new CryptoStream(
			fsData, 
			rijn.CreateEncryptor(), 
			CryptoStreamMode.Write);

		//get plaintext in array of bytes
		UnicodeEncoding ue = new UnicodeEncoding();
		byte [] bytes = ue.GetBytes(strPlaintext);

		//encrypt and write ciphertext
		csData.Write(bytes, 0, bytes.Length);

		//close things up
		csData.Close();
		fsData.Close();
	}
}
