//TinyRSA.cs

//NOTE: Just to be safe, check arithmetic for
//      overflow/underflow, so compile with
//      the /checked option turned on.

using System;

class TinyRSA
{
	static void Main(string[] args)
	{
		int p = GetSmallRandomPrime();
		Console.WriteLine("Prime p: " + p);

		int q; //ensure that p != q
		while (true)
		{
			q = GetSmallRandomPrime();
			if (p != q)
				break;
		}
		Console.WriteLine("Prime q: " + q);

		int pq = p*q; //p, q are small, cannot overflow
		Console.WriteLine("Product of primes pq: " + pq);

		int phi = (p-1)*(q-1); //euler totient
		Console.WriteLine("Euler totient phi: " + phi);

		int e = GetRandomRelPrime(phi);
		Console.WriteLine(
			"Random relative prime e: " + e);

		int d = ModInverse(e, phi);
		Console.WriteLine("Modular inverse d: " + d);

		Console.WriteLine("\nKeep private: d.");
		Console.WriteLine("Make public: e, and pq.\n");

		//ensure that plaintext is less than modulus pq
		int plaintext = random.Next(0, pq); 
		Console.WriteLine(
			"Random plaintext: " + plaintext);

		int ciphertext = ModPow(plaintext, e, pq);
		Console.WriteLine(
			"Encrypted ciphertext: " + ciphertext);

		int decryptedtext = ModPow(ciphertext, d, pq);
		Console.WriteLine(
			"Decrypted text: " + decryptedtext);

		if (plaintext == decryptedtext)
			Console.WriteLine("\nCipher succeeded!\n");
		else
			Console.WriteLine("\nCipher failed!\n");
	}
	static int GetSmallRandomPrime()
	{
		while(true)
		{
			//real RSA crypto uses multiprecision, not int
			int candidate = random.Next(5, 100);
			if (IsPrime(candidate))
				return candidate;
		}
	}
	static bool IsPrime(int candidate)
	{
		//not the most efficient, but understandable!
		int sqrroot = (int)Math.Sqrt(candidate);
		for(int divisor = 2; divisor<=sqrroot; divisor++) 
		{
			if (candidate%divisor == 0)
				return false; //not prime
		}
		return true; //got this far so must be prime
	}
	static int GetRandomRelPrime(int phi)
	{
		//get random positive signed rel prime integer
		while(true)
		{
			//ensure that rel prime is less than phi
			int candidate = random.Next(5, phi);
			if (IsRelPrime(candidate, phi))
				return candidate;
		}
	}
	static bool IsRelPrime(int candidate, int phi)
	{
		//calculate GCD using euclidean algorithm
		int a = phi;
		int b = candidate;
		while (b > 0)
		{
			int q = a/b;
			int r = a%b;
			a = b;
			b = r;
		}
		int gcd = a;

		//if gcd == 1, then they are rel prime
		return a == 1;
	}
	static int ModInverse(int e, int modulus)
	{
		//modular multiplicative inverse of e
		//there are faster ways, but this is clearest
		for (int d = 1; d<=0x7FFFFFFF; d++)
		{
			long prod = (e*d)%modulus;
			if (prod == 1)
				return d;
		}
		throw new Exception("No modular inverse found!");
	}
	static int ModPow(int val, int exponent, int modulus)
	{
		//val raised to the power of exponent, mod phi
		//use care in arithmetic to avoid long overflow
		long result = 1;
		for (int i=1; i<=exponent; i++)
			result = (result*val) % modulus;
		return (int)result;
	}
	static private Random random = new Random();
}
