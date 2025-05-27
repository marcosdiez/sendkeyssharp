using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using System.Runtime.InteropServices;

// https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

namespace SendKeysSharp
{



    public partial class Form1 : Form
    {

        string clickToType = "Click to Type !";
        string typing = "Typing...";

        public Form1()
        {
            InitializeComponent();
            txt_main.Focus();
            txt_main.SelectAll();
            txt_main.Focus();
            go_button.Text = clickToType;
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            go_button.Text = typing;
            go_button.Update();
            SendKeys.Send("%{Tab}"); // so we focus the previous app
            Thread.Sleep(1000);
            var t = new Typer();
            t.CitrixTypeSentence(txt_main.Text);
            go_button.Text = clickToType;
            go_button.Update();
        }
    }
}
