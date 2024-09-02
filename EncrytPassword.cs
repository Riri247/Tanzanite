using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Hashpass
{
	public static class EncryptP
	{
		public static String EncryptPassword(String password)
		{
			int saltSize=16; //128 bit salt
			int keySize=32; //256 bit hash
			int iterations=10000;
			
			//generating the salt 
			byte[] salt= new byte[saltSize];
			using(var Ranger= new RNGCryptoServiceProvider())
            {
				Ranger.GetBytes(salt);
            }
			// Generating the hash using PBKDF2
			byte[] hash;
			using (var pbkdf2= new Rfc2898DeriveBytes(password,salt,iterations,HashAlgorithmName.SHA256))
            {
				hash=pbkdf2.GetBytes(keySize);
            }
			//separating salt and hash 
			String hashedPassword =Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
			return hashedPassword;
		}
	}
}