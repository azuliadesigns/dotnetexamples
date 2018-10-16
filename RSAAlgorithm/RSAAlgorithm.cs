using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Text; 

namespace RSAAlgorithm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class RSAAlgorithm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textPlaintext;
		private System.Windows.Forms.Button buttonEncrypt;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textRecoveredPlaintext;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textCiphertext;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonDecrypt;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textCipherbytes;
		private System.Windows.Forms.TextBox textBoxP;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxQ;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxE;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxD;
		private System.Windows.Forms.Button buttonNewRSAParams;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RSAAlgorithm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textPlaintext = new System.Windows.Forms.TextBox();
			this.buttonEncrypt = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textRecoveredPlaintext = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textCiphertext = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonDecrypt = new System.Windows.Forms.Button();
			this.textCipherbytes = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxP = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxQ = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxE = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxD = new System.Windows.Forms.TextBox();
			this.buttonNewRSAParams = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// textPlaintext
			// 
			this.textPlaintext.Location = new System.Drawing.Point(8, 16);
			this.textPlaintext.Multiline = true;
			this.textPlaintext.Name = "textPlaintext";
			this.textPlaintext.Size = new System.Drawing.Size(600, 24);
			this.textPlaintext.TabIndex = 0;
			this.textPlaintext.Text = "";
			// 
			// buttonEncrypt
			// 
			this.buttonEncrypt.Location = new System.Drawing.Point(8, 280);
			this.buttonEncrypt.Name = "buttonEncrypt";
			this.buttonEncrypt.TabIndex = 1;
			this.buttonEncrypt.Text = "Encrypt";
			this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textPlaintext});
			this.groupBox1.Location = new System.Drawing.Point(8, 224);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(616, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Plaintext";
			// 
			// textRecoveredPlaintext
			// 
			this.textRecoveredPlaintext.Location = new System.Drawing.Point(16, 504);
			this.textRecoveredPlaintext.Multiline = true;
			this.textRecoveredPlaintext.Name = "textRecoveredPlaintext";
			this.textRecoveredPlaintext.ReadOnly = true;
			this.textRecoveredPlaintext.Size = new System.Drawing.Size(592, 24);
			this.textRecoveredPlaintext.TabIndex = 9;
			this.textRecoveredPlaintext.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(8, 488);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(616, 48);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recovered Plaintext";
			// 
			// textCiphertext
			// 
			this.textCiphertext.Location = new System.Drawing.Point(16, 328);
			this.textCiphertext.Multiline = true;
			this.textCiphertext.Name = "textCiphertext";
			this.textCiphertext.ReadOnly = true;
			this.textCiphertext.Size = new System.Drawing.Size(600, 24);
			this.textCiphertext.TabIndex = 2;
			this.textCiphertext.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(8, 312);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(616, 48);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ciphertext Displayed as Text String";
			// 
			// buttonDecrypt
			// 
			this.buttonDecrypt.Enabled = false;
			this.buttonDecrypt.Location = new System.Drawing.Point(8, 456);
			this.buttonDecrypt.Name = "buttonDecrypt";
			this.buttonDecrypt.TabIndex = 8;
			this.buttonDecrypt.Text = "Decrypt";
			this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
			// 
			// textCipherbytes
			// 
			this.textCipherbytes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textCipherbytes.Location = new System.Drawing.Point(16, 376);
			this.textCipherbytes.Multiline = true;
			this.textCipherbytes.Name = "textCipherbytes";
			this.textCipherbytes.ReadOnly = true;
			this.textCipherbytes.Size = new System.Drawing.Size(600, 64);
			this.textCipherbytes.TabIndex = 3;
			this.textCipherbytes.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(8, 360);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(616, 88);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ciphertext Displayed as Byte Array";
			// 
			// textBoxP
			// 
			this.textBoxP.Location = new System.Drawing.Point(24, 16);
			this.textBoxP.Multiline = true;
			this.textBoxP.Name = "textBoxP";
			this.textBoxP.ReadOnly = true;
			this.textBoxP.Size = new System.Drawing.Size(576, 32);
			this.textBoxP.TabIndex = 4;
			this.textBoxP.Text = "";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label1,
																					this.label2,
																					this.textBoxQ,
																					this.textBoxP,
																					this.label3,
																					this.textBoxE,
																					this.label4,
																					this.textBoxD});
			this.groupBox5.Location = new System.Drawing.Point(8, 40);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(616, 176);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "RSA Parameters";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "P";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Q";
			// 
			// textBoxQ
			// 
			this.textBoxQ.Location = new System.Drawing.Point(24, 56);
			this.textBoxQ.Multiline = true;
			this.textBoxQ.Name = "textBoxQ";
			this.textBoxQ.ReadOnly = true;
			this.textBoxQ.Size = new System.Drawing.Size(576, 32);
			this.textBoxQ.TabIndex = 5;
			this.textBoxQ.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "E";
			// 
			// textBoxE
			// 
			this.textBoxE.Location = new System.Drawing.Point(24, 96);
			this.textBoxE.Multiline = true;
			this.textBoxE.Name = "textBoxE";
			this.textBoxE.ReadOnly = true;
			this.textBoxE.Size = new System.Drawing.Size(576, 32);
			this.textBoxE.TabIndex = 6;
			this.textBoxE.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "D";
			// 
			// textBoxD
			// 
			this.textBoxD.Location = new System.Drawing.Point(24, 136);
			this.textBoxD.Multiline = true;
			this.textBoxD.Name = "textBoxD";
			this.textBoxD.ReadOnly = true;
			this.textBoxD.Size = new System.Drawing.Size(576, 32);
			this.textBoxD.TabIndex = 7;
			this.textBoxD.Text = "";
			// 
			// buttonNewRSAParams
			// 
			this.buttonNewRSAParams.Location = new System.Drawing.Point(8, 8);
			this.buttonNewRSAParams.Name = "buttonNewRSAParams";
			this.buttonNewRSAParams.Size = new System.Drawing.Size(136, 23);
			this.buttonNewRSAParams.TabIndex = 1;
			this.buttonNewRSAParams.Text = "New RSA Parameters";
			this.buttonNewRSAParams.Click += new System.EventHandler(this.buttonNewRSAParams_Click);
			// 
			// RSAAlgorithm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 541);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonEncrypt,
																		  this.textRecoveredPlaintext,
																		  this.groupBox2,
																		  this.textCiphertext,
																		  this.groupBox3,
																		  this.buttonDecrypt,
																		  this.groupBox1,
																		  this.buttonNewRSAParams,
																		  this.groupBox5,
																		  this.textCipherbytes,
																		  this.groupBox4});
			this.Name = "RSAAlgorithm";
			this.Text = "RSAAlgorithm";
			this.Load += new System.EventHandler(this.RSAAlgorithm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new RSAAlgorithm());
		}

		private void RSAAlgorithm_Load(
			object sender, System.EventArgs e)
		{
			GenerateNewRSAParams();
		}

		private void buttonNewRSAParams_Click(
			object sender, System.EventArgs e)
		{
			GenerateNewRSAParams();
		}

		private void GenerateNewRSAParams()
		{
			//establish RSA asymmetric algorithm
			RSACryptoServiceProvider rsa = 
				new RSACryptoServiceProvider();

			//provide public and private RSA params
			rsaParamsIncludePrivate = 
				rsa.ExportParameters(true);

			//provide public only RSA params
			rsaParamsExcludePrivate = 
				rsa.ExportParameters(false);

			//display RSA parameter details in hex format
			StringBuilder sb = new StringBuilder();
			for (int i=0; 
				i<rsaParamsIncludePrivate.P.Length; i++)
			{
				sb.Append(String.Format(
					"{0,2:X2} ", 
					rsaParamsIncludePrivate.P[i]));
			}
			textBoxP.Text = sb.ToString();
			sb = new StringBuilder();
			for (int i=0; 
				i<rsaParamsIncludePrivate.Q.Length; i++)
			{
				sb.Append(String.Format(
					"{0,2:X2} ", 
					rsaParamsIncludePrivate.Q[i]));
			}
			textBoxQ.Text = sb.ToString();
			sb = new StringBuilder();
			for (int i=0; 
				i<rsaParamsIncludePrivate.Exponent.Length; 
				i++)
			{
				sb.Append(String.Format(
					"{0,2:X2} ", 
					rsaParamsIncludePrivate.Exponent[i]));
			}
			textBoxE.Text = sb.ToString();
			sb = new StringBuilder();
			for (int i=0; 
				i<rsaParamsIncludePrivate.D.Length; i++)
			{
				sb.Append(String.Format(
					"{0,2:X2} ", 
					rsaParamsIncludePrivate.D[i]));
			}
			textBoxD.Text = sb.ToString();

			buttonEncrypt.Enabled = true;
		}

		private void buttonEncrypt_Click(
			object sender, System.EventArgs e)
		{
			//do UI stuff
			ClearOutputFields();

			//establish RSA using parameters from encrypt
			RSACryptoServiceProvider rsa = 
				new RSACryptoServiceProvider();

			//import public only RSA parameters for encrypt
			rsa.ImportParameters(rsaParamsExcludePrivate);

			//read plaintext, encrypt it to ciphertext
			byte[] plainbytes = 
				Encoding.UTF8.GetBytes(textPlaintext.Text);
			cipherbytes = 
				rsa.Encrypt(
				plainbytes, 
				false); //fOAEP needs high encryption pack

			//display ciphertext as text string
			textCiphertext.Text = 
				Encoding.UTF8.GetString(cipherbytes);

			//display ciphertext byte array in hex format
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<cipherbytes.Length; i++)
			{
				sb.Append(String.Format(
					"{0,2:X2} ", cipherbytes[i]));
			}
			textCipherbytes.Text = sb.ToString();

			//do UI stuff
			buttonNewRSAParams.Enabled = false;
			buttonEncrypt.Enabled = false;
			buttonDecrypt.Enabled = true;
			textPlaintext.Enabled = false;
			buttonDecrypt.Select();
		}

		private void buttonDecrypt_Click(
			object sender, System.EventArgs e)
		{
			//establish RSA using parameters from encrypt
			RSACryptoServiceProvider rsa = 
				new RSACryptoServiceProvider();

			//import public and private RSA paramaters
			rsa.ImportParameters(rsaParamsIncludePrivate);

			//read ciphertext, decrypt it to plaintext
			byte[] plainbytes = 
				rsa.Decrypt(
				cipherbytes, 
				false); //fOAEP needs high encryption pack

			//display recovered plaintext
			textRecoveredPlaintext.Text = 
				Encoding.UTF8.GetString(plainbytes);

			//do UI stuff
			buttonNewRSAParams.Enabled = true;
			buttonDecrypt.Enabled = false;
			textPlaintext.Enabled = true;
			buttonEncrypt.Select();
		}

		private void ClearOutputFields()
		{
			//do UI stuff
			textCiphertext.Text = "";
			textCipherbytes.Text = "";
			textRecoveredPlaintext.Text = "";
		}

		//public modulus and exponent used in encryption
		RSAParameters rsaParamsExcludePrivate; 

		//public and private RSA params use in decryption
		RSAParameters rsaParamsIncludePrivate;

		//variable communicated from encrypt to decrypt
		byte[] cipherbytes;
	}
}
