using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopLocker
{
    public partial class Form1 : Form
    {
        private readonly string pass = "unlock";
        private bool check = true;

        public Form1()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.textBox1.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 140, Screen.PrimaryScreen.Bounds.Height / 2);
            this.button1.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 + 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "unlock")
            {
                check = false;
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check)
            {
                e.Cancel = true;
            }
        }
    }
}
