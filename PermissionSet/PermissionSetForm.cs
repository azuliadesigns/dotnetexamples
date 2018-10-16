//PermissionSetForm.cs

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Security;
using System.Security.Permissions;
using System.IO;
using System.Text;

namespace PermissionSetForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class PermissionSetForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton radioButtonDeny;
		private System.Windows.Forms.RadioButton radioButtonPermitOnly;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonAttemptFileAccess;
		private System.Windows.Forms.Button buttonAttemptEnvVarAccess;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxFileIOPermissionAccessRead;
		private System.Windows.Forms.CheckBox checkBoxFileIOPermissionAccessWrite;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBoxEnvironmentPermissionRead;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBoxAllWindows;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PermissionSetForm()
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
			this.radioButtonDeny = new System.Windows.Forms.RadioButton();
			this.radioButtonPermitOnly = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonAttemptFileAccess = new System.Windows.Forms.Button();
			this.buttonAttemptEnvVarAccess = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxFileIOPermissionAccessWrite = new System.Windows.Forms.CheckBox();
			this.checkBoxFileIOPermissionAccessRead = new System.Windows.Forms.CheckBox();
			this.checkBoxEnvironmentPermissionRead = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkBoxAllWindows = new System.Windows.Forms.CheckBox();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioButtonDeny
			// 
			this.radioButtonDeny.Location = new System.Drawing.Point(216, 32);
			this.radioButtonDeny.Name = "radioButtonDeny";
			this.radioButtonDeny.Size = new System.Drawing.Size(80, 24);
			this.radioButtonDeny.TabIndex = 4;
			this.radioButtonDeny.Text = "Deny";
			// 
			// radioButtonPermitOnly
			// 
			this.radioButtonPermitOnly.Location = new System.Drawing.Point(216, 64);
			this.radioButtonPermitOnly.Name = "radioButtonPermitOnly";
			this.radioButtonPermitOnly.Size = new System.Drawing.Size(80, 24);
			this.radioButtonPermitOnly.TabIndex = 4;
			this.radioButtonPermitOnly.Text = "PermitOnly";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(200, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 88);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PermissionSet Action";
			// 
			// buttonAttemptFileAccess
			// 
			this.buttonAttemptFileAccess.Location = new System.Drawing.Point(200, 128);
			this.buttonAttemptFileAccess.Name = "buttonAttemptFileAccess";
			this.buttonAttemptFileAccess.Size = new System.Drawing.Size(144, 23);
			this.buttonAttemptFileAccess.TabIndex = 5;
			this.buttonAttemptFileAccess.Text = "Attempt File Access";
			this.buttonAttemptFileAccess.Click += new System.EventHandler(this.buttonAttemptFileAccess_Click);
			// 
			// buttonAttemptEnvVarAccess
			// 
			this.buttonAttemptEnvVarAccess.Location = new System.Drawing.Point(200, 160);
			this.buttonAttemptEnvVarAccess.Name = "buttonAttemptEnvVarAccess";
			this.buttonAttemptEnvVarAccess.Size = new System.Drawing.Size(144, 23);
			this.buttonAttemptEnvVarAccess.TabIndex = 6;
			this.buttonAttemptEnvVarAccess.Text = "Attempt Env Var Access";
			this.buttonAttemptEnvVarAccess.Click += new System.EventHandler(this.buttonAttemptEnvVarAccess_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.checkBoxFileIOPermissionAccessWrite});
			this.groupBox2.Location = new System.Drawing.Point(24, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 88);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "FileIOPermissionAccess ";
			// 
			// checkBoxFileIOPermissionAccessWrite
			// 
			this.checkBoxFileIOPermissionAccessWrite.Location = new System.Drawing.Point(16, 56);
			this.checkBoxFileIOPermissionAccessWrite.Name = "checkBoxFileIOPermissionAccessWrite";
			this.checkBoxFileIOPermissionAccessWrite.TabIndex = 1;
			this.checkBoxFileIOPermissionAccessWrite.Text = "Write";
			// 
			// checkBoxFileIOPermissionAccessRead
			// 
			this.checkBoxFileIOPermissionAccessRead.Location = new System.Drawing.Point(40, 32);
			this.checkBoxFileIOPermissionAccessRead.Name = "checkBoxFileIOPermissionAccessRead";
			this.checkBoxFileIOPermissionAccessRead.TabIndex = 1;
			this.checkBoxFileIOPermissionAccessRead.Text = "Read";
			// 
			// checkBoxEnvironmentPermissionRead
			// 
			this.checkBoxEnvironmentPermissionRead.Location = new System.Drawing.Point(40, 128);
			this.checkBoxEnvironmentPermissionRead.Name = "checkBoxEnvironmentPermissionRead";
			this.checkBoxEnvironmentPermissionRead.TabIndex = 2;
			this.checkBoxEnvironmentPermissionRead.Text = "Read";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(24, 104);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(152, 56);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "EnvironmentPermission";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.checkBoxAllWindows});
			this.groupBox4.Location = new System.Drawing.Point(24, 176);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(152, 56);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "UIPermission";
			// 
			// checkBoxAllWindows
			// 
			this.checkBoxAllWindows.Location = new System.Drawing.Point(16, 24);
			this.checkBoxAllWindows.Name = "checkBoxAllWindows";
			this.checkBoxAllWindows.Size = new System.Drawing.Size(128, 24);
			this.checkBoxAllWindows.TabIndex = 3;
			this.checkBoxAllWindows.TabStop = false;
			this.checkBoxAllWindows.Text = "Permit All Windows";
			// 
			// PermissionSetForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(368, 269);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkBoxFileIOPermissionAccessRead,
																		  this.radioButtonDeny,
																		  this.radioButtonPermitOnly,
																		  this.groupBox1,
																		  this.buttonAttemptFileAccess,
																		  this.buttonAttemptEnvVarAccess,
																		  this.groupBox2,
																		  this.checkBoxEnvironmentPermissionRead,
																		  this.groupBox3,
																		  this.groupBox4});
			this.Name = "PermissionSetForm";
			this.Text = "PermissionSet Example";
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new PermissionSetForm());
		}

		private void buttonAttemptFileAccess_Click(
			object sender, System.EventArgs e)
		{
			//build perm set according to radio buttons
			EstablishPermissionSet();

			//Deny, or PermitOnly
			if (radioButtonDeny.Checked)
				ps.Deny();
			if (radioButtonPermitOnly.Checked)
				ps.PermitOnly();

			//attempt to open or create file
			FileStream fs = null; //for TestFile.txt file
			try
			{
				fs = new FileStream(
					"TestFile.txt", 
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite);
			}
			catch (Exception) 
			{
			}
			if (fs == null)
			{
				try
				{
					fs = new FileStream(
						"TestFile.txt", 
						FileMode.OpenOrCreate,
						FileAccess.Read);
				}
				catch (Exception) 
				{
				}
			}
			if (fs == null)
			{
				try
				{
					fs = new FileStream(
						"TestFile.txt", 
						FileMode.OpenOrCreate,
						FileAccess.Write);
				}
				catch (Exception) 
				{
				}
			}
			if (fs == null)
			{
				MessageBox.Show(
					"FAILURE: open file");
				return;
			}

			String strMessageBox = 
				"SUCCESS: open file" +
				", CanWrite: " + fs.CanWrite +
				", CanRead: " + fs.CanRead +
				".\n";

			//attempt to write file
			String strDataOut = "Some Data";
			byte [] bytes= 
				Encoding.UTF8.GetBytes(strDataOut);
			try
			{
				fs.Write(bytes, 0, bytes.Length);

				strMessageBox += "SUCCESS: write file - "
					+ strDataOut + "\n";
			}
			catch (Exception)
			{
				strMessageBox += 
					"FAILURE: write file.\n";
			}

			//attempt to read file
			bytes = new byte[256];
			try
			{
				fs.Seek(0, SeekOrigin.Begin);
				fs.Read(bytes, 0, bytes.Length);

				String strDataIn = Encoding.UTF8.GetString(
					bytes, 0, bytes.Length);
				strMessageBox += 
					"SUCCESS: read file - " + strDataIn;
			}
			catch (Exception)
			{
				strMessageBox += "FAILURE: read file.\n";
			}

			//show result of attempts
			MessageBox.Show(strMessageBox);

			fs.Close();

			//RevertDeny or RevertPermitOnly
			if (radioButtonDeny.Checked)
				CodeAccessPermission.RevertDeny();
			if (radioButtonPermitOnly.Checked)
				CodeAccessPermission.RevertPermitOnly();

			//clean up permission set
			DestroyPermissionSet();
		}

		private void buttonAttemptEnvVarAccess_Click(
			object sender, System.EventArgs e)
		{
			//build perm set according to radio buttons
			EstablishPermissionSet();

			//Deny or PermitOnly
			if (radioButtonDeny.Checked)
				ps.Deny();
			if (radioButtonPermitOnly.Checked)
				ps.PermitOnly();

			//attempt to read TEMP environment variable
			String ev = null;
			try
			{
				ev = Environment.GetEnvironmentVariable(
					"TEMP");

				//show result of attempt
				MessageBox.Show(
					"SUCCESS: read environment variable - " + 
					ev);
			}
			catch (Exception) 
			{
				MessageBox.Show(
					"FAILURE: read environment variable");
			}

			//RevertDeny or RevertPermitOnly
			if (radioButtonDeny.Checked)
				CodeAccessPermission.RevertDeny();
			if (radioButtonPermitOnly.Checked)
				CodeAccessPermission.RevertPermitOnly();

			//clean up permission set
			DestroyPermissionSet();
		}

		//build permission set according to radio buttons
		private void EstablishPermissionSet()
		{
			ps = new PermissionSet(PermissionState.None);

			//establish EnvironmentPermission
			EnvironmentPermission ep = 
				new EnvironmentPermission(
					EnvironmentPermissionAccess.NoAccess,
					"TEMP");
			if (checkBoxEnvironmentPermissionRead.Checked)
			{
				ep.AddPathList(
					EnvironmentPermissionAccess.Read, 
					"TEMP");
			}
			ps.AddPermission(ep);

			//establish FileIOPermission
			FileIOPermission fp = 
				new FileIOPermission(
					FileIOPermissionAccess.NoAccess,
					Path.GetFullPath("TestFile.txt"));
			if (checkBoxFileIOPermissionAccessRead.Checked)
			{
				fp.AddPathList(
					FileIOPermissionAccess.Read, 
					Path.GetFullPath("TestFile.txt"));
			}
			if (checkBoxFileIOPermissionAccessWrite.Checked)
			{
				fp.AddPathList(
					FileIOPermissionAccess.Write, 
					Path.GetFullPath("TestFile.txt"));
			}
			ps.AddPermission(fp);

			//establish UIPermission
			UIPermission  uip = new UIPermission(
				UIPermissionWindow.NoWindows);
			if (checkBoxAllWindows.Checked)
			{
				uip.Window = 
					UIPermissionWindow.AllWindows;
			}
			ps.AddPermission(uip);
		}

		void DestroyPermissionSet()
		{
			ps.RemovePermission(
				typeof(EnvironmentPermission));
			ps.RemovePermission(
				typeof(FileIOPermission));
			ps.RemovePermission(
				typeof(UIPermission));
			ps = null;
		}

		PermissionSet ps;
	}
}
