namespace InheritedControls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myInheritedControl1 = new InheritedControls.MyInheritedControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myInheritedControl1
            // 
            this.myInheritedControl1.Location = new System.Drawing.Point(80, 48);
            this.myInheritedControl1.MyNonBrowsableProperty = 0;
            this.myInheritedControl1.Name = "myInheritedControl1";
            this.myInheritedControl1.Size = new System.Drawing.Size(100, 20);
            this.myInheritedControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyInheritedControl - only accepts numic Keys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myInheritedControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyInheritedControl myInheritedControl1;
        private System.Windows.Forms.Label label1;
    }
}

