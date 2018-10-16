//Receiver.cs

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class SymmetricCryptoReceiver
{
	static void Main(string[] args)
	{
		//plaintext to get from decryption
		String strPlaintext;

		//encrypt and send the plaintext string
		strPlaintext = ReadAndDecrypt();

		Console.WriteLine("Plaintext: " + strPlaintext);
	}

	private static String ReadAndDecrypt()
	{
		//create crypto provider using the default key
		SymmetricAlgorithm rijn = SymmetricAlgorithm.Create();

		//get key and iv info from file streams
		FileStream fsKeyInfo = new FileStream(
			"..\\..\\..\\keyinfo.txt",
			FileMode.Open, FileAccess.Read);
		FileStream fsIVInfo = new FileStream(
			"..\\..\\..\\ivinfo.txt",
			FileMode.Open, FileAccess.Read);

		//read key info
		byte [] bytes32 = new byte[rijn.Key.Length];
		fsKeyInfo.Read(bytes32, 0, rijn.Key.Length);
		rijn.Key = bytes32;
		byte [] bytes16 = new byte[rijn.IV.Length];
		fsIVInfo.Read(bytes16, 0, rijn.IV.Length);
		rijn.IV = bytes16;
		fsKeyInfo.Close();
		fsIVInfo.Close();

		//create input file and stream for encrypted data
		FileStream fs = new FileStream(
			"..\\..\\..\\ciphertext.txt",
			FileMode.Open, FileAccess.Read);

		//establish crypto stream
		CryptoStream cs = new CryptoStream(
			fs, 
			rijn.CreateDecryptor(), 
			CryptoStreamMode.Read);

		//read and decrypt string
		UnicodeEncoding ue = new UnicodeEncoding();
		StreamReader sr = new StreamReader(cs, ue);
		String strDecrypted = sr.ReadToEnd();

		//close things up
		cs.Close();
		fs.Close();

		//return decrypted string
		return strDecrypted;
	}
}
