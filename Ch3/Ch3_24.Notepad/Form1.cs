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
    public partial class Form1 : Form
    {
        private string loadedFileName="";
        Logger logger;
        public Form1()
        {
            
            InitializeComponent();
            logger = new Logger(Application.ExecutablePath + "log.txt");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            Log("User selected cut operation");
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            Log("User selected copy operation");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            Log("User selected paste operation");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            Log("User selected undo operation");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            Log("User selected redo operation");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            Log("User selected select all operation");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFileDialog(DialogType.Font);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Log("User selected new operation");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowFileDialog(DialogType.Open);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad -Untitled" ;
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(loadedFileName))
            {
                SaveAs();
            }
            else
            {
                richTextBox1.SaveFile(loadedFileName, RichTextBoxStreamType.PlainText);
                this.Text = "Notepad -" + loadedFileName;
            }
           
        }
        private void SaveAs()
        {
            ShowFileDialog(DialogType.Save );
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered By Mr.Terimorian", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToShortTimeString();
        }

        private void ShowFileDialog(DialogType dialogType)
        {
            if (dialogType ==  DialogType.Open)
            {
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                //open file dialog
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    loadedFileName = openFileDialog1.FileName;
                    richTextBox1.LoadFile(loadedFileName, RichTextBoxStreamType.PlainText);
                    this.Text = "Notepad -" + loadedFileName;
                }
                Log("User selected open operation");
            }
            else if (dialogType == DialogType.Save)
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                //save file dialog
                DialogResult dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    loadedFileName = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(loadedFileName, RichTextBoxStreamType.PlainText);
                    this.Text = "Notepad -" + loadedFileName;
                }
                Log("User selected save operation");
            }
            else if(dialogType== DialogType.Font)
            {
                DialogResult dr = fontDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
                Log("User selected font operation");
            }
        }


        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatrixView formMatrixView = new FormMatrixView();
            formMatrixView.ShowDialog(this);
            string output = formMatrixView.MatrixResult;
            richTextBox1.Text += "\r\n" + output + "\r\n";
            Log("User selected new matrix operation");
        }

        private void Log(string message)
        {
            logger.Log(message);
        }

    }
}
