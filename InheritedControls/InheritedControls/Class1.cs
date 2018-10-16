using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InheritedControls
{
    class MyInheritedControl : TextBox
    {
        private int _MyNonBrowsableProperty;

        [System.ComponentModel.Browsable(false)]
        public int MyNonBrowsableProperty
        {
            get { return _MyNonBrowsableProperty; }
            set { _MyNonBrowsableProperty = value; }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            /*
             * If the e.Handled is not left false, then it is
             * not handled here and it will be sent to the
             * operating system for default processing. 
             * Set e.Handled to true to cancel the KeyPress event.
             */

            if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
