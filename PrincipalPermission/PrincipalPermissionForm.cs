using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Security;
using System.Security.Permissions;

using System.Security.Principal;
using System.Threading;

namespace PrincipalPermissionExample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class PrincipalPermissionForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxUserRole;
		private System.Windows.Forms.Button buttonTest;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PrincipalPermissionForm()
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
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxUserRole = new System.Windows.Forms.TextBox();
			this.buttonTest = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(8, 16);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(184, 20);
			this.textBoxUserName.TabIndex = 0;
			this.textBoxUserName.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textBoxUserName});
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 48);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textBoxUserRole});
			this.groupBox2.Location = new System.Drawing.Point(8, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 48);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "User Role";
			// 
			// textBoxUserRole
			// 
			this.textBoxUserRole.Location = new System.Drawing.Point(8, 16);
			this.textBoxUserRole.Name = "textBoxUserRole";
			this.textBoxUserRole.Size = new System.Drawing.Size(184, 20);
			this.textBoxUserRole.TabIndex = 0;
			this.textBoxUserRole.Text = "";
			// 
			// buttonTest
			// 
			this.buttonTest.Location = new System.Drawing.Point(32, 136);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(144, 23);
			this.buttonTest.TabIndex = 2;
			this.buttonTest.Text = "Test PrincipalPermission";
			this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
			// 
			// PrincipalPermissionForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(216, 165);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonTest,
																		  this.groupBox1,
																		  this.groupBox2});
			this.Name = "PrincipalPermissionForm";
			this.Text = "PrincipalPermission";
			this.groupBox1.ResumeLayout(false);
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
			Application.Run(new PrincipalPermissionForm());
		}

		private void buttonTest_Click(
			object sender, System.EventArgs e)
		{
			//set default principal for appdomain threads
			AppDomain appdomain = AppDomain.CurrentDomain;
			appdomain.SetPrincipalPolicy(
				PrincipalPolicy.WindowsPrincipal);

			String strUserName = textBoxUserName.Text;
			if (strUserName.Equals(""))
				strUserName = null;
			String strUserRole = textBoxUserRole.Text;
			if (strUserRole.Equals(""))
				strUserRole = null;

			PrincipalPermission pp = 
				new PrincipalPermission(
				strUserName, strUserRole);

			//can throw SecurityException if wrong user
			pp.Demand();

			//if we got this far, then user is OK
			MessageBox.Show(
				"Specified user matches current user." +
				"User permitted to proceed.");

		}
	}
}
