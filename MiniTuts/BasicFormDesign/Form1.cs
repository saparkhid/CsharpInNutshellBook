
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFormDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPass.Text;
            newUser.Nation = cmbCountry.Text;
            newUser.Gender = 0;
            if(radFemale.Checked) newUser.Gender = 1;
            newUser.Age = (int)numericUpDownAge.Value;

            string json = JsonConvert.SerializeObject(newUser);
      
            Clipboard.SetText(json);
            MessageBox.Show(json);


        }
    }
}
