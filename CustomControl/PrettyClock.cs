using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ControlTestCSharp
{
	/// <summary>
	/// Summary description for PrettyClock.
	/// </summary>
    /// 

    //[ToolboxBitmap(@"C:\PrettyClock.bmp")]
    //[ToolboxBitmap(typeof(Button))]
	public class PrettyClock : System.Windows.Forms.Control
	{
		public PrettyClock()
		{
			InitializeComponent();
		}
		// Adds the private variable to hold the Color value
		private Color mForeColorTwo;
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.Timer timer1;
		// Adds the property itself
		public Color ForeColorTwo
		{
			get
			{
				return mForeColorTwo;
			}
			set
			{
				mForeColorTwo = value;
			}
		}
		private float mAngle = 0;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

		}
	
		public float Angle
		{
			get
			{
				return mAngle;
			}
			set
			{
				// This scheme causes the value to be set low if an attempt is 
				// made to set it high, and vice-versa. This allows one to circle
				// through the angle path by incrementing the property
				if (value > 360)
					mAngle = 0;
				else if (value < 0)
					mAngle = 360;
				else
					mAngle = value;
			}
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			// This line creates a new rectangle that represents the control 
			// created from the origin point and the control's Size property
			Rectangle ControlRectangle = new Rectangle(new Point(0, 0), this.Size);
			// This line creates a new LinearGradientBrush that blends 
			// ForeColor and ForeColorTwo along the angle specified in angle. 
			LinearGradientBrush myBrush = new LinearGradientBrush(ControlRectangle,
				ForeColor, ForeColorTwo, Angle);
			// Creates a GraphicsPath object that will hold the text to be 
			// rendered
			GraphicsPath myPath = new GraphicsPath();
			// Adds a string representing the current time to the GraphicsPath
			myPath.AddString(System.DateTime.Now.ToLongTimeString(), Font.FontFamily, 
				(int)Font.Style, Font.Size, new Point(0, 0), StringFormat.GenericDefault);
			// Renders the Graphis path
			pe.Graphics.FillPath(myBrush, myPath);
			// Creates a pen from myBrush with a thickness of 8 pixels
			Pen myPen = new Pen(myBrush, 8);
			// Renders a rectangle around the control
			pe.Graphics.DrawRectangle(myPen, ControlRectangle);


		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			
			// This will cause the visual effect to change with each Tick
			Angle += 10;
			// Causes the control to redraw
			this.Refresh();

		}
	}
}
