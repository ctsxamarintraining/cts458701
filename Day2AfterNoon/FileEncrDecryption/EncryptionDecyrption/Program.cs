using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace EncryptionDecyrption
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FileStream FileStream1 = new FileStream("MyFileToEncrypt.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer = new StreamWriter(FileStream1);
			string data = Console.ReadLine();
			Console.WriteLine (data);
			writer.Write(data);
			writer.Close();
			string StringToBeencrypted = CipherDecipher.EncryptMethod<AesManaged>(data, "pass", "halo");
			string StringToBeenDeCrypted = CipherDecipher.DecryptMethod<AesManaged>(StringToBeencrypted, "pass", "halo");
		
			Console.WriteLine (StringToBeencrypted);
			Console.WriteLine (StringToBeenDeCrypted);

		}
	}


	public class CipherDecipher
	{
		public static string EncryptMethod<T>(string value, string pass, string halo)
			where T : SymmetricAlgorithm, new()
		{
			DeriveBytes rgb = new Rfc2898DeriveBytes(pass, Encoding.Unicode.GetBytes(halo));

			SymmetricAlgorithm algorithm = new T();

			byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
			byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

			ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

			using (MemoryStream buffer = new MemoryStream())
			{
				using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
				{
					using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
					{
						writer.Write(value);
					}
				}

				return Convert.ToBase64String(buffer.ToArray());
			}
		}

		public static string DecryptMethod<T>(string text, string pass, string halo)
			where T : SymmetricAlgorithm, new()
		{
			DeriveBytes rgb = new Rfc2898DeriveBytes(pass, Encoding.Unicode.GetBytes(halo));

			SymmetricAlgorithm algorithm = new T();

			byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
			byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

			ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIV);

			using (MemoryStream buffer = new MemoryStream(Convert.FromBase64String(text)))
			{
				using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
				{
					using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
					{
						return reader.ReadToEnd();
					}
				}
			}
		}
	}
}
