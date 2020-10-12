using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinAPIHelper.RegisterHotKey(this.Handle, 102, WinAPIHelper.KeyModifiers.Ctrl, Keys.F8);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WinAPIHelper.WM_HOTKEY)
            {
                if ((int)m.WParam == 102)
                {
                    txtOutput.Text += @"按下了F8
";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
