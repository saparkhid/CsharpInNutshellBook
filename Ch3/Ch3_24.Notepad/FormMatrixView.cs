using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_24.Notepad
{
    public partial class FormMatrixView : Form
    {
        Logger logger;

        string result = "";
        public FormMatrixView()
        {
            InitializeComponent();
            logger = new Logger(Application.ExecutablePath + "log.txt");
        }

        private void FormMatrixView_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Log("element 1,1 changed");
        }

        private void Log(string message)
        {
            logger.Log(message);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Log("element 1,2 changed");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Log("element 1,3 changed");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Log("element 1,4 changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\t" + textBox5.Text + "\t" + textBox6.Text + "\t" + textBox7.Text + "\t" + textBox8.Text;
            Log("new matrix inserted");
            this.Close();
        }

        public string MatrixResult
        {
            get
            {
                return result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
