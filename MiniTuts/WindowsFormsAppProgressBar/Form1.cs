using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppProgressBar
{
    public partial class Form1 : Form
    {
        private long _counter = 0;
        private long _fileSizeInBytes;
        int _bytesRead;
        private string _fileName;
        private FileStream _fs;
        int _percent = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSetProgress_Click(object sender, EventArgs e)
        {
            string valStr = textBoxPbarValue.Text;
            int val = int.Parse(valStr);
            if (val < progressBar1.Minimum)
            {
                val = progressBar1.Minimum;
                textBoxPbarValue.Text= progressBar1.Minimum.ToString();
            }
            if (val > progressBar1.Maximum)
            {
                val = progressBar1.Maximum;
                textBoxPbarValue.Text = progressBar1.Maximum.ToString();
            }
            progressBar1.Value = val;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            _fileName = openFileDialog1.FileName;

            _fileSizeInBytes = new FileInfo(_fileName).Length;
            progressBar1.Maximum = 100;

            _fs = new FileStream(_fileName, FileMode.Open);
            lblLoaded.Text="Loaded 0%";
           _counter = 0;
            progressBar1.Value = 0;
            _percent = 0;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while ((_bytesRead = _fs.ReadByte()) != -1)
            {
                _percent = (int)(100.0D * ((double)_counter / (double)_fileSizeInBytes));
                _counter++;
                backgroundWorker1.ReportProgress(_percent);
               
            }
       

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblLoaded.Text = "Please wait loading : %" + _percent.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            lblLoaded.Text = "Please wait loading : %100";
            MessageBox.Show("finished");
        }
    }
}
