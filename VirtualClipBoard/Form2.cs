using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace VirtualClipBoard
{
    public partial class Form2 : Form
    {
        private string message = null;
        public Form2(string str)
        {
            //this.PointToScreen();
            this.StartPosition = FormStartPosition.CenterScreen;
            message = str;
            InitializeComponent();
            this.TopMost = true;
            System.Timers.Timer t = new System.Timers.Timer(2500);
            t.Elapsed += new System.Timers.ElapsedEventHandler(Sumbit);
            t.AutoReset = false;   //设置是执行一次（false）还是一直执行(true)；   
            t.Enabled = true;


        }

        private void Sumbit(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
               this.Close();
            }));

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 5;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height-30 ;
            this.Location = new Point(ScreenWidth, ScreenHeight);
            if (message != null)
            {
                this.richTextBox1.Text = message;

            }


        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 5;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 5;
            this.Location = new Point(ScreenWidth, ScreenHeight);
        }
    }
}
