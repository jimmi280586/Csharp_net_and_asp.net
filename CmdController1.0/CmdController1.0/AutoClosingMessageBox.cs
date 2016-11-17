using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdController1._0
{
    /**
     * this method is borrowed from stack overflow but i have commented the cose so i can understand what it does
     */
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;//enitializes a timer thread
        string _caption;
        //constructor taking in the text, caption is to tell that it have to be uniformed text and then it takes the time in milli seconds
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            //set caption to the caption field
            _caption = caption;
            //instantiate the timer thread
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed, null, timeout, System.Threading.Timeout.Infinite);
            //shows the message box using the messagebox method show (system api)
            MessageBox.Show(text, caption);
        }
        //method to call when wanting to run this timed message box
        public static void Show(string text, string caption, int timeout)
        {
            //creates a new message box
            new AutoClosingMessageBox(text, caption, timeout);
        }
        //this method as i understand keeps track of the time the message box is open and when time is up it closes the given box
        void OnTimerElapsed(object state)
        {
            //find the window with the given caption
            IntPtr mbWnd = FindWindow(null, _caption);
            //if the time is not zero
            if (mbWnd != IntPtr.Zero)
                //keep message up if not zero
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            //close the message box
            _timeoutTimer.Dispose();
        }
        /**
         *i do not fully understand what this part does 
         */
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}
