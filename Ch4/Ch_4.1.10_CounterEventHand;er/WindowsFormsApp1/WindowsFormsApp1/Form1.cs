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
        Counter counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            counter = new Counter(int.Parse(textBoxStart.Text), int.Parse(textBoxMul.Text));
            counter.CounterChanged += Counter_OnValueChanged;
            counter.CounterThresholdReceived += Counter_ThresholdReceived;
            timer1.Enabled = true;
            timer1.Start();
        }

        /// <summary>
        /// Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Counter_OnValueChanged(object sender, CounterEventArgs e)
        {
            lblCurrentCounter.Text = "Current:" + e.Number.ToString();
        }
        private void Counter_ThresholdReceived(object sender, CounterEventArgs e)
        {
            int n = e.Number;
            listBox1.Items.Add(n);
        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter != null)
            {
                counter.Increase();
            }
        }
    }
}
