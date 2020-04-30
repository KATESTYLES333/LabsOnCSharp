using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsa
{
	public partial class Form1 : Form
	{
		RSAParameters privateKey;
		RSAParameters publicKey;

		public Form1()
		{
			InitializeComponent();

			//Пункт 1
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
			//Пункт 2
			privateKey = RSA.ExportParameters(true);
			publicKey = RSA.ExportParameters(false);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UnicodeEncoding byteConverter = new UnicodeEncoding();
			byte[] input = byteConverter.GetBytes(textBox1.Text);
			byte[] output;
			//Пункт 3
			output = RSAEncrypt(input, publicKey, false);

			textBox2.Text = byteConverter.GetString(output);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UnicodeEncoding byteConverter = new UnicodeEncoding();
			byte[] input = byteConverter.GetBytes(textBox3.Text);
			byte[] output;
			//Пункт 4
			output = RSADecrypt(input, privateKey, false);

			textBox4.Text = byteConverter.GetString(output);
		}

		static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
		{
			//Create a new instance of RSACryptoServiceProvider.
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

			//Import the RSA Key information. This only needs
			//toinclude the public key information.
			RSA.ImportParameters(RSAKeyInfo);

			//Encrypt the passed byte array and specify OAEP padding.  
			//OAEP padding is only available on Microsoft Windows XP or
			//later.  
			return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
		}

		static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
		{
			//Create a new instance of RSACryptoServiceProvider.
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

			//Import the RSA Key information. This needs
			//to include the private key information.
			RSA.ImportParameters(RSAKeyInfo);

			//Decrypt the passed byte array and specify OAEP padding.  
			//OAEP padding is only available on Microsoft Windows XP or
			//later.  
			return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
