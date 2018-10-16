using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Security;
using System.Security.Principal;
using System.Threading;

namespace ImperativeUserBasedSecurity
{
	/// <summary>
	/// Summary description for Form.
	/// </summary>
	public class ImperativeUserBasedSecurityForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textUserName;
		private System.Windows.Forms.Button buttonTestOnUserName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTestOnRole;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButtonGuest;
		private System.Windows.Forms.RadioButton radioButtonUser;
		private System.Windows.Forms.RadioButton radioButtonAdministrator;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImperativeUserBasedSecurityForm()
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
			this.textUserName = new System.Windows.Forms.TextBox();
			this.buttonTestOnUserName = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTestOnRole = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonGuest = new System.Windows.Forms.RadioButton();
			this.radioButtonUser = new System.Windows.Forms.RadioButton();
			this.radioButtonAdministrator = new System.Windows.Forms.RadioButton();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textUserName
			// 
			this.textUserName.Location = new System.Drawing.Point(108, 43);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(272, 20);
			this.textUserName.TabIndex = 5;
			this.textUserName.Text = "";
			// 
			// buttonTestOnUserName
			// 
			this.buttonTestOnUserName.Location = new System.Drawing.Point(164, 83);
			this.buttonTestOnUserName.Name = "buttonTestOnUserName";
			this.buttonTestOnUserName.Size = new System.Drawing.Size(160, 23);
			this.buttonTestOnUserName.TabIndex = 8;
			this.buttonTestOnUserName.Text = "Test On User Name";
			this.buttonTestOnUserName.Click += new System.EventHandler(this.buttonTestOnUserName_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(100, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 48);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MachineName\\UserName (try valid or invalid name)";
			// 
			// buttonTestOnRole
			// 
			this.buttonTestOnRole.Location = new System.Drawing.Point(164, 243);
			this.buttonTestOnRole.Name = "buttonTestOnRole";
			this.buttonTestOnRole.Size = new System.Drawing.Size(160, 23);
			this.buttonTestOnRole.TabIndex = 9;
			this.buttonTestOnRole.Text = "Test On Role";
			this.buttonTestOnRole.Click += new System.EventHandler(this.buttonTestOnRole_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButtonGuest,
																					this.radioButtonUser,
																					this.radioButtonAdministrator});
			this.groupBox2.Location = new System.Drawing.Point(100, 187);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 48);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Role";
			// 
			// radioButtonGuest
			// 
			this.radioButtonGuest.Checked = true;
			this.radioButtonGuest.Location = new System.Drawing.Point(16, 16);
			this.radioButtonGuest.Name = "radioButtonGuest";
			this.radioButtonGuest.Size = new System.Drawing.Size(64, 24);
			this.radioButtonGuest.TabIndex = 3;
			this.radioButtonGuest.TabStop = true;
			this.radioButtonGuest.Text = "Guest";
			// 
			// radioButtonUser
			// 
			this.radioButtonUser.Location = new System.Drawing.Point(104, 16);
			this.radioButtonUser.Name = "radioButtonUser";
			this.radioButtonUser.Size = new System.Drawing.Size(48, 24);
			this.radioButtonUser.TabIndex = 4;
			this.radioButtonUser.Text = "User";
			// 
			// radioButtonAdministrator
			// 
			this.radioButtonAdministrator.Location = new System.Drawing.Point(176, 16);
			this.radioButtonAdministrator.Name = "radioButtonAdministrator";
			this.radioButtonAdministrator.Size = new System.Drawing.Size(96, 24);
			this.radioButtonAdministrator.TabIndex = 5;
			this.radioButtonAdministrator.Text = "Administrator";
			// 
			// ImperativeUserBasedSecurityForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textUserName,
																		  this.buttonTestOnUserName,
																		  this.groupBox1,
																		  this.buttonTestOnRole,
																		  this.groupBox2});
			this.Name = "ImperativeUserBasedSecurityForm";
			this.Text = "Imperative User Based Security";
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ImperativeUserBasedSecurityForm());
		}

		private void buttonTestOnUserName_Click(
			object sender, System.EventArgs e)
		{
			//set default principal for appdomain threads
			AppDomain appdomain = AppDomain.CurrentDomain;
			appdomain.SetPrincipalPolicy(
				PrincipalPolicy.WindowsPrincipal);

			//get current principal object
			WindowsPrincipal principle = 
				(WindowsPrincipal)Thread.CurrentPrincipal;

			//get specified user name string
			string userName = textUserName.Text;

			//execute code according to specified user name
			if (!principle.Identity.Name.Equals(userName))
			{
				throw new SecurityException(
					"Specified user is " + 
					userName +
					".\n" +
					"Therefore current user " +
					principle.Identity.Name + 
					" is NOT permitted to proceed.");
			}
			MessageBox.Show(
				"Specified user is " + 
				userName +
				".\n" +
				"Therefore current user " +
				principle.Identity.Name + 
				" is permitted to proceed.");
		}

		private void buttonTestOnRole_Click(
			object sender, System.EventArgs e)
		{
			//set default principal for appdomain threads
			AppDomain appdomain = AppDomain.CurrentDomain;
			appdomain.SetPrincipalPolicy(
				PrincipalPolicy.WindowsPrincipal);

			//get current principal object
			WindowsPrincipal principle = 
				(WindowsPrincipal)Thread.CurrentPrincipal;

			//get specified role
			WindowsBuiltInRole role = 0;
			if (radioButtonGuest.Checked == true)
				role = WindowsBuiltInRole.Guest;
			if (radioButtonUser.Checked == true)
				role = WindowsBuiltInRole.User;
			if (radioButtonAdministrator.Checked == true)
				role = WindowsBuiltInRole.Administrator;

			//execute code according to specified role
			if (!principle.IsInRole(role))
			{
				throw new SecurityException(
					"Specified role is " + 
					role +
					".\n" +
					"Therefore current user " +
					principle.Identity.Name + 
					" is NOT permitted to proceed.");
			}
			MessageBox.Show(
				"Specified role is " + 
				role +
				".\n" +
				"Therefore current user " +
				principle.Identity.Name + 
				" is permitted to proceed.");
		}
	}
}
