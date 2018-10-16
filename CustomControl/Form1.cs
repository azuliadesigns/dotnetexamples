using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ControlTestCSharp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private ControlTestCSharp.PrettyClock prettyClock1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
            this.prettyClock1 = new ControlTestCSharp.PrettyClock();
            this.SuspendLayout();
            // 
            // prettyClock1
            // 
            this.prettyClock1.Angle = 280F;
            this.prettyClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prettyClock1.ForeColor = System.Drawing.Color.Lime;
            this.prettyClock1.ForeColorTwo = System.Drawing.Color.Red;
            this.prettyClock1.Location = new System.Drawing.Point(8, 8);
            this.prettyClock1.Name = "prettyClock1";
            this.prettyClock1.Size = new System.Drawing.Size(225, 50);
            this.prettyClock1.TabIndex = 0;
            this.prettyClock1.Text = "prettyClock1";
            this.prettyClock1.Click += new System.EventHandler(this.prettyClock1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.prettyClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

        private void prettyClock1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(prettyClock1.Angle.ToString());
        }
	}
}
