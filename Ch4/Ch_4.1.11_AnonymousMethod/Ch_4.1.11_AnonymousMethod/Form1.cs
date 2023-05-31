using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_4._1._11_AnonymousMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button1.Click += delegate (object _sender, EventArgs _e)
            {
                this.Close();
            };
        }


        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //please see line 19 ; uses anonymous method
        }
    }
}
