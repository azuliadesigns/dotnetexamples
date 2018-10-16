using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace DeclarativeUserBasedSecurity
{
	/// <summary>
	/// Summary description for Form.
	/// </summary>
	public class DeclarativeUserBasedSecurityForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonTest;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DeclarativeUserBasedSecurityForm()
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
			this.buttonTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonTest
			// 
			this.buttonTest.Location = new System.Drawing.Point(95, 55);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.TabIndex = 0;
			this.buttonTest.Text = "Test";
			this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
			// 
			// DeclarativeUserBasedSecurityForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 133);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonTest});
			this.Name = "DeclarativeUserBasedSecurityForm";
			this.Text = "Declarative User Based Security";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			//set default principal for appdomain threads
			AppDomain appdomain = AppDomain.CurrentDomain;
			appdomain.SetPrincipalPolicy(
				PrincipalPolicy.WindowsPrincipal);

			Application.Run(new DeclarativeUserBasedSecurityForm());
		}

		[PrincipalPermission(
			 SecurityAction.Demand,
			 Name="softech125\\Administrator")]
		private void buttonTest_Click(
			object sender, System.EventArgs e)
		{
			MessageBox.Show(
				"Specified user is permitted to proceed.");
		}
	}
}
