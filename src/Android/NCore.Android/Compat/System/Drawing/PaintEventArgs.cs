using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Drawing;

namespace System.Windows.Forms
{
    public class PaintEventArgs : EventArgs
    {
        public Graphics Graphics { get; set; }
    }
}