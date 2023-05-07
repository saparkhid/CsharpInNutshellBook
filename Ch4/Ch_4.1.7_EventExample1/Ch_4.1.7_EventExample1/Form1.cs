using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_4._1._7_EventExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mouse move event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="mouseData"></param>
        private void Form1_MouseMove(object sender, MouseEventArgs mouseData)
        {
            int x = mouseData.X;
            int y = mouseData.Y;
            label1.Text = "MouseX: " + x.ToString();
            label2.Text = "MouseY: " + y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label3.Text="Key:"+ (char)e.KeyValue;
        }
    }
}
